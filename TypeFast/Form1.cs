using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
namespace TypeFast
{
	public partial class MainForm : Form
	{
		bool maximized;
		public const int BorderWidth = 16;
		int wordIndex, selectionStart;
		Text[] texts;
		Text currentText;
		int currentTextIndex = -1;
		int secondsPassed;
		int wpm;
		int cpm;
		int bestWpm = int.MinValue;
		int bestCpm = int.MinValue;
		int charsWritten;
		readonly Color textColor, rightColor, wrongColor;
		bool timerStarted = false;
		bool running = false;
		void LoadTexts(string filename)
		{
			string[] textsStr = File.ReadAllLines(filename);
			texts = new Text[textsStr.Length];

			for (int i = 0; i < texts.Length; ++i)
			{
				texts[i] = new Text(textsStr[i]);
			}
		}
		public MainForm()
		{
			InitializeComponent();
			menuStrip.Renderer = new ToolStripProfessionalRenderer(new MyColorTable());

			textColor = textBox.ForeColor;
			rightColor = Color.FromArgb(64, 255, 64);
			wrongColor = Color.FromArgb(255, 32, 32);
			LoadTexts("texts.txt");
		}
		Text GetNextText()
		{
			if (texts.Length == 1)
			{
				return texts[0];
			}
			if (texts.Length == 0)
			{
				return null;
			}
			++currentTextIndex;
			if (currentTextIndex == texts.Length)
			{
				currentTextIndex = 0;
			}

			return texts[currentTextIndex];
		}
		void UpdateStartStopButtonText(bool start)
		{
			startStopButton.Text = start ? "Start" : "Stop";
		}

		void StopGame()
		{
			timer1.Stop();
			int originalSelectionStart = inputTextBox.SelectionStart;
			inputTextBox.SelectionStart = 0;
			inputTextBox.SelectionLength = inputTextBox.Text.Length;
			inputTextBox.SelectionColor = textColor;
			inputTextBox.SelectionLength = 1;
			inputTextBox.SelectionStart = originalSelectionStart;
			textBox.SelectionStart = 0;
			textBox.SelectionLength = textBox.Text.Length;
			textBox.SelectionColor = textColor;
			inputTextBox.Clear();
			inputTextBox.Enabled = false;
			wordIndex = 0;
			charsWritten = 0;
			UpdateStartStopButtonText(true);
			running = false;
			openToolStripMenuItem.Enabled = true;
			startStopButton.Focus();
		}
		private void startStopButton_Click(object sender, EventArgs e)
		{
			Win32.EnableRepaint(textBox.Handle, false);
			if (running)
			{
				textBox.Clear();
				inputTextBox.Enabled = false;
				timerStarted = false;
				StopGame();
			}
			else
			{
				//if (wordIndex != currentText.words.Length)
				//{
				//	return;
				//}

				inputTextBox.Enabled = true;
				currentText = GetNextText();
				textBox.Text = currentText.text;
				
				UpdateStartStopButtonText(false);
				_ = inputTextBox.Focus();
				secondsPassed = 0;
				UpdateTimeLabel();
				timerStarted = false;
				running = true;
				openToolStripMenuItem.Enabled = false;
				selectionStart = 0;
			}
			Win32.EnableRepaint(textBox.Handle, true);
			textBox.Invalidate();
		}
		void UpdateTimeLabel()
		{
			timeLabel.Text = $"Time: {secondsPassed} seconds";
		}
		private void timer1_Tick(object sender, EventArgs e)
		{
			++secondsPassed;
			UpdateTimeLabel();
		}
		void Finish()
		{
			bestWpm = Math.Max(bestWpm, wpm);
			bestCpm = Math.Max(bestCpm, cpm);
			bestWpmLabel.Text = $"Best words per minute: {bestWpm}";
			bestCharsPerMinuteLabel.Text = $"Best characters per minute: {bestCpm}";
			secondsPassed = 0;
			StopGame();
		}
		private void inputTextBox_TextChanged(object sender, EventArgs e)
		{
			if (!timerStarted)
			{
				timerStarted = true;
				timer1.Start();
			}
			string word = currentText.words[wordIndex];
			string input = inputTextBox.Text;

			Win32.EnableRepaint(textBox.Handle, false);

			if (input == word)
			{
				// The word is written
				++wordIndex;
				inputTextBox.Clear();
				textBox.SelectionStart = selectionStart;
				textBox.SelectionLength = word.Length;
				textBox.SelectionColor = rightColor;
				selectionStart += word.Length;

				float minutesPassed = Math.Max(secondsPassed, 1) / 60.0f;

				wpm = (int)(wordIndex / minutesPassed);

				charsWritten += word.Length;
				cpm = (int)(charsWritten / minutesPassed);
				
				wpmLabel.Text = $"Words per minute: {wpm}";
				charsPerMinuteLabel.Text = $"Characters per minute: {cpm}";
				wordCountLabel.Text = $"Words: {wordIndex}";
				if (wordIndex == currentText.words.Length)
				{
					Finish();
				}
			}
			else
			{
				int diffStart = -1;
				for (int i = 0; ; ++i)
				{
					if (i >= word.Length || i >= input.Length)
					{
						break;
					}
					if (word[i] != input[i])
					{
						diffStart = i;
						break;
					}
				}
				int originalSelectionStart = inputTextBox.SelectionStart;
				if (diffStart == -1)
				{
					inputTextBox.SelectionStart = 0;
					inputTextBox.SelectionLength = input.Length;
					inputTextBox.SelectionColor = textColor;
				}
				else
				{
					inputTextBox.SelectionStart = diffStart;
					inputTextBox.SelectionLength = input.Length - diffStart;
					inputTextBox.SelectionColor = wrongColor;
				}
				inputTextBox.SelectionStart = originalSelectionStart;
				inputTextBox.SelectionLength = 0;
			}
			Win32.EnableRepaint(textBox.Handle, true);
			textBox.Invalidate();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void maximizeButton_Click(object sender, EventArgs e)
		{
			WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
		}

		/*
		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			var rect = DisplayRectangle;
			rect.X -= 5;
			rect.Y -= 5;
			rect.Width += 10;
			rect.Height += 10;
			Win32.SetWindowRgn(Handle, Win32.CreateRoundRectRgn(rect, 16, 16), true);
		}
		*/

		private void openToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				LoadTexts(openFileDialog.FileName);
			}
		}

		protected static int MakeLong(short lowPart, short highPart) => (int)(((ushort)lowPart) | (uint)(highPart << 16));

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			Point p = Cursor.Position;
			_ = Win32.SendMessage(Handle, Win32.WM_SYSMENU, (IntPtr)0, (IntPtr)MakeLong((short)p.X, (short)p.Y));
		}

		private void minimizeButton_Click(object sender, EventArgs e)
		{
			WindowState = FormWindowState.Minimized;
		}
		protected override void WndProc(ref Message m)
		{
			switch (m.Msg)
			{
				case Win32.WM_SYSCOMMAND:
				{
					maximized = (int)m.WParam == Win32.SC_MAXIMIZE;
					break;
				}
				case Win32.WM_SIZE:
				{
					maximized = (int)m.WParam == Win32.SIZE_MAXIMIZED;
					break;
				}
				case Win32.WM_NCPAINT:
				{
					//break;
					if (Dwm.CompositionEnabled)
					{
						//var v = 2;
						//Dwm.SetWindowAttribute(Handle, 2, ref v, 4);
						MARGINS margins = new MARGINS(1);
						Dwm.ExtendFrameIntoClientArea(Handle, ref margins);
					}
					break;
				}
				case Win32.WM_NCCALCSIZE:
				{
					var r = (RECT)Marshal.PtrToStructure(m.LParam, typeof(RECT));
					var max = WindowState == FormWindowState.Maximized;

					if (max)
					{
						var x = Win32.GetSystemMetrics(Win32.SM_CXSIZEFRAME);
						var y = Win32.GetSystemMetrics(Win32.SM_CYSIZEFRAME);
						var p = Win32.GetSystemMetrics(Win32.SM_CXPADDEDBORDER);
						var w = x + p;
						var h = y + p;

						r.left += w;
						r.top += h;
						r.right -= w;
						r.bottom -= h;

						var appBarData = new APPBARDATA();
						appBarData.cbSize = Marshal.SizeOf(typeof(APPBARDATA));
						var autohide = (Win32.SHAppBarMessage(Win32.ABM_GETSTATE, ref appBarData) & Win32.ABS_AUTOHIDE) != 0;
						if (autohide)
							r.bottom -= 1;
						
						Marshal.StructureToPtr(r, m.LParam, true);
					}

					m.Result = IntPtr.Zero;
					return;
				}
				case Win32.WM_NCHITTEST:
				{
					int x = m.LParam.ToInt32() & 0xFFFF;
					int y = (m.LParam.ToInt32() >> 16) & 0xFFFF;
					Point c = PointToClient(new Point(x, y));
					x = c.X;
					y = c.Y;
					int result;
					if (WindowState == FormWindowState.Maximized)
					{
						result = Win32.HTCAPTION;
					}
					else
					{
						if (x < BorderWidth)
						{
							if (y < BorderWidth)
							{
								result = Win32.HTTOPLEFT;
							}
							else if (y >= Height - BorderWidth)
							{
								result = Win32.HTBOTTOMLEFT;
							}
							else
							{
								result = Win32.HTLEFT;
							}
						}
						else if (x >= Width - BorderWidth)
						{
							if (y < BorderWidth)
							{
								result = Win32.HTTOPRIGHT;
							}
							else if (y >= Height - BorderWidth)
							{
								result = Win32.HTBOTTOMRIGHT;
							}
							else
							{
								result = Win32.HTRIGHT;
							}
						}
						else
						{
							if (y < BorderWidth)
							{
								result = Win32.HTTOP;
							}
							else if (y >= Height - BorderWidth)
							{
								result = Win32.HTBOTTOM;
							}
							else
							{
								result = Win32.HTCAPTION;
							}
						}
					}
					m.Result = new IntPtr(result);
					return;
				}
				default: break;
			}
			base.WndProc(ref m);
		}
		//protected override CreateParams CreateParams
		//{
		//	get
		//	{
		//		var p = base.CreateParams;
		//		//if (!Dwm.CompositionEnabled)
		//			p.ClassStyle |= Win32.CS_DROPSHADOW;
		//		return p;
		//	}
		//}
	}
	public class Text
	{
		public string text;
		public string[] words;
		public Text(string text)
		{
			this.text = text;

			words = text.Split(' ');

			for (int j = 0; j < words.Length - 1; ++j)
				words[j] += ' ';
		}
	}
}
