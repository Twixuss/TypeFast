using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;

namespace TypeFast
{
	[StructLayout(LayoutKind.Sequential)]
	public struct MARGINS
	{
		public int leftWidth;
		public int rightWidth;
		public int topHeight;
		public int bottomHeight;
		public MARGINS(int all)
		{
			leftWidth = all;
			rightWidth = all;
			topHeight = all;
			bottomHeight = all;
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct RECT
	{
		public int left;
		public int top;
		public int right;
		public int bottom;

		public RECT(int left, int top, int right, int bottom)
		{
			this.left = left;
			this.top = top;
			this.right = right;
			this.bottom = bottom;
		}

		public static RECT FromXYWH(int x, int y, int width, int height)
		{
			return new RECT(x,
							y,
							x + width,
							y + height);
		}
	}
	[StructLayout(LayoutKind.Sequential)]
	public struct APPBARDATA
	{
		public int cbSize; // initialize this field using: Marshal.SizeOf(typeof(APPBARDATA));
		public IntPtr hWnd;
		public uint uCallbackMessage;
		public uint uEdge;
		public RECT rc;
		public int lParam;
	}
	public static class Win32
	{
		public const int SIZE_MAXIMIZED = 2;
		public const int WM_SIZE = 0x0005;
		public const int WM_SETREDRAW = 0x000B;
		public const int WM_ACTIVATEAPP = 0x001C;
		public const int WM_NCCALCSIZE = 0x0083;
		public const int WM_NCHITTEST = 0x0084;
		public const int WM_NCPAINT = 0x0085;
		public const int WM_SYSCOMMAND = 0x0112;
        public const int WM_SYSMENU = 0x313;
		public const int CS_DROPSHADOW = 0x00020000;
		public const int HTCLIENT = 1;
		public const int HTCAPTION = 2;
		public const int HTLEFT = 10;
		public const int HTRIGHT = 11;
		public const int HTTOP = 12;
		public const int HTTOPLEFT = 13;
		public const int HTTOPRIGHT = 14;
		public const int HTBOTTOM = 15;
		public const int HTBOTTOMLEFT = 16;
		public const int HTBOTTOMRIGHT = 17;
		public const int AW_VER_POSITIVE = 0x00000004;
		public const int AW_VER_NEGATIVE = 0x00000008;
		public const int AW_SLIDE = 0x00040000;
		public const int AW_HIDE = 0x00010000;
		public const int SC_MINIMIZE = 0xF020;
		public const int SC_MAXIMIZE = 0xF030;
		public const int SC_RESTORE = 0xF120;
		public const int WS_MAXIMIZE = 0x01000000;
		public const int WS_MINIMIZE = 0x20000000;
		public const int WS_BORDER = 0x00800000;
		public const int WS_DLGFRAME = 0x00400000;
		public const int WS_CAPTION = WS_BORDER | WS_DLGFRAME;
		public const int GWL_STYLE = -16;
		public const int SM_CXSIZEFRAME = 32;
		public const int SM_CYSIZEFRAME = 33;
		public const int SM_CXPADDEDBORDER = 92;
		public const uint ABM_GETSTATE = 0x4;
		public const int ABS_AUTOHIDE = 0x1;
		[DllImport("user32.dll")] public static extern int SetWindowLong(IntPtr hWnd, int nIndex, int dwNewLong);
		[DllImport("user32.dll")] public static extern int GetWindowLong(IntPtr hWnd, int nIndex);
		[DllImport("user32.dll")] public static extern bool AnimateWindow(IntPtr hwnd, int dwTime, int dwFlags);
		[DllImport("user32.dll")] public static extern int GetSystemMetrics(int smIndex);
		[DllImport("user32.dll")] public static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);
		[DllImport("user32.dll")] public static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
		[DllImport("user32.dll")] public static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, IntPtr lParam);

		[DllImport("Gdi32.dll")] public static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
		[DllImport("shell32.dll")] public static extern int SHAppBarMessage(uint dwMessage, [In] ref APPBARDATA pData);
		public static IntPtr CreateRoundRectRgn(Rectangle rect, int sizeX, int sizeY) => CreateRoundRectRgn(rect.Left, rect.Top, rect.Right, rect.Bottom, sizeX, sizeY);
		public static void EnableRepaint(IntPtr handle, bool enable) => SendMessage(handle, WM_SETREDRAW, (IntPtr)(enable ? 1 : 0), IntPtr.Zero);
	}
	public static class Dwm
	{
		[DllImport("dwmapi.dll", EntryPoint = "DwmExtendFrameIntoClientArea")] public static extern int ExtendFrameIntoClientArea(IntPtr hWnd, ref MARGINS pMarInset);
		[DllImport("dwmapi.dll", EntryPoint = "DwmSetWindowAttribute")] public static extern int SetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);
		[DllImport("dwmapi.dll", EntryPoint = "DwmIsCompositionEnabled")] public static extern int IsCompositionEnabled(ref int pfEnabled);
		private static bool? compositionEnabled;
		public static bool CompositionEnabled
		{
			get
			{
				if (compositionEnabled == null)
				{
					if (Environment.OSVersion.Version.Major >= 6)
					{
						int enabled = 0;
						IsCompositionEnabled(ref enabled);
						compositionEnabled = enabled == 1;
					}
					else
					{
						compositionEnabled = false;
					}
				}
				return (bool)compositionEnabled;
			}
		}
	}
}
