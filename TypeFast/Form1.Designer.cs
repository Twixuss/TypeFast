namespace TypeFast
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox = new System.Windows.Forms.RichTextBox();
			this.inputTextBox = new System.Windows.Forms.RichTextBox();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.minimizeButton = new System.Windows.Forms.Button();
			this.maximizeButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.wordCountLabel = new System.Windows.Forms.Label();
			this.bestWpmLabel = new System.Windows.Forms.Label();
			this.startStopButton = new System.Windows.Forms.Button();
			this.wpmLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.menuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox
			// 
			this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
			this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox.DetectUrls = false;
			this.textBox.ForeColor = System.Drawing.Color.Gainsboro;
			this.textBox.Location = new System.Drawing.Point(8, 80);
			this.textBox.Margin = new System.Windows.Forms.Padding(16);
			this.textBox.Name = "textBox";
			this.textBox.ReadOnly = true;
			this.textBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.textBox.Size = new System.Drawing.Size(652, 218);
			this.textBox.TabIndex = 1;
			this.textBox.TabStop = false;
			this.textBox.Text = "";
			// 
			// inputTextBox
			// 
			this.inputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.inputTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(42)))));
			this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.inputTextBox.Enabled = false;
			this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.inputTextBox.ForeColor = System.Drawing.Color.Gainsboro;
			this.inputTextBox.Location = new System.Drawing.Point(16, 346);
			this.inputTextBox.Margin = new System.Windows.Forms.Padding(6);
			this.inputTextBox.Multiline = false;
			this.inputTextBox.Name = "inputTextBox";
			this.inputTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
			this.inputTextBox.Size = new System.Drawing.Size(651, 38);
			this.inputTextBox.TabIndex = 2;
			this.inputTextBox.Text = "";
			this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog1";
			// 
			// menuStrip
			// 
			this.menuStrip.AutoSize = false;
			this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
			this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
			this.menuStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(40, 8);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(60, 32);
			this.menuStrip.Stretch = false;
			this.menuStrip.TabIndex = 3;
			this.menuStrip.TabStop = true;
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
			this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 28);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
			this.openToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.openToolStripMenuItem.ForeColor = System.Drawing.Color.Gainsboro;
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 28);
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox1.Location = new System.Drawing.Point(8, 8);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.TabIndex = 15;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// minimizeButton
			// 
			this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.minimizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
			this.minimizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(16)))));
			this.minimizeButton.FlatAppearance.BorderSize = 0;
			this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
			this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.minimizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.minimizeButton.ForeColor = System.Drawing.Color.White;
			this.minimizeButton.Image = ((System.Drawing.Image)(resources.GetObject("minimizeButton.Image")));
			this.minimizeButton.Location = new System.Drawing.Point(556, 8);
			this.minimizeButton.Name = "minimizeButton";
			this.minimizeButton.Size = new System.Drawing.Size(40, 32);
			this.minimizeButton.TabIndex = 3;
			this.minimizeButton.TabStop = false;
			this.minimizeButton.UseVisualStyleBackColor = false;
			this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
			// 
			// maximizeButton
			// 
			this.maximizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.maximizeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
			this.maximizeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(32)))), ((int)(((byte)(128)))));
			this.maximizeButton.FlatAppearance.BorderSize = 0;
			this.maximizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
			this.maximizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.maximizeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.maximizeButton.ForeColor = System.Drawing.Color.White;
			this.maximizeButton.Image = ((System.Drawing.Image)(resources.GetObject("maximizeButton.Image")));
			this.maximizeButton.Location = new System.Drawing.Point(596, 8);
			this.maximizeButton.Name = "maximizeButton";
			this.maximizeButton.Size = new System.Drawing.Size(40, 32);
			this.maximizeButton.TabIndex = 4;
			this.maximizeButton.TabStop = false;
			this.maximizeButton.UseVisualStyleBackColor = false;
			this.maximizeButton.Click += new System.EventHandler(this.maximizeButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(84)))));
			this.closeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(16)))), ((int)(((byte)(32)))));
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.closeButton.ForeColor = System.Drawing.Color.White;
			this.closeButton.Image = ((System.Drawing.Image)(resources.GetObject("closeButton.Image")));
			this.closeButton.Location = new System.Drawing.Point(636, 8);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(40, 32);
			this.closeButton.TabIndex = 5;
			this.closeButton.TabStop = false;
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// wordCountLabel
			// 
			this.wordCountLabel.AutoSize = true;
			this.wordCountLabel.ForeColor = System.Drawing.Color.Gainsboro;
			this.wordCountLabel.Location = new System.Drawing.Point(116, 40);
			this.wordCountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.wordCountLabel.Name = "wordCountLabel";
			this.wordCountLabel.Size = new System.Drawing.Size(99, 26);
			this.wordCountLabel.TabIndex = 9;
			this.wordCountLabel.Text = "Words: 0";
			// 
			// bestWpmLabel
			// 
			this.bestWpmLabel.AutoSize = true;
			this.bestWpmLabel.ForeColor = System.Drawing.Color.Gainsboro;
			this.bestWpmLabel.Location = new System.Drawing.Point(298, 40);
			this.bestWpmLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.bestWpmLabel.Name = "bestWpmLabel";
			this.bestWpmLabel.Size = new System.Drawing.Size(253, 26);
			this.bestWpmLabel.TabIndex = 6;
			this.bestWpmLabel.Text = "Best words per minute: 0";
			// 
			// startStopButton
			// 
			this.startStopButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(70)))), ((int)(((byte)(110)))));
			this.startStopButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.startStopButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
			this.startStopButton.FlatAppearance.BorderSize = 0;
			this.startStopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startStopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
			this.startStopButton.ForeColor = System.Drawing.Color.Gainsboro;
			this.startStopButton.Location = new System.Drawing.Point(8, 8);
			this.startStopButton.Margin = new System.Windows.Forms.Padding(6);
			this.startStopButton.Name = "startStopButton";
			this.startStopButton.Size = new System.Drawing.Size(96, 64);
			this.startStopButton.TabIndex = 0;
			this.startStopButton.Text = "Start";
			this.startStopButton.UseVisualStyleBackColor = false;
			this.startStopButton.Click += new System.EventHandler(this.startStopButton_Click);
			// 
			// wpmLabel
			// 
			this.wpmLabel.AutoSize = true;
			this.wpmLabel.ForeColor = System.Drawing.Color.Gainsboro;
			this.wpmLabel.Location = new System.Drawing.Point(298, 8);
			this.wpmLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.wpmLabel.Name = "wpmLabel";
			this.wpmLabel.Size = new System.Drawing.Size(208, 26);
			this.wpmLabel.TabIndex = 5;
			this.wpmLabel.Text = "Words per minute: 0";
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.ForeColor = System.Drawing.Color.Gainsboro;
			this.timeLabel.Location = new System.Drawing.Point(116, 8);
			this.timeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(171, 26);
			this.timeLabel.TabIndex = 3;
			this.timeLabel.Text = "Time: 0 seconds";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
			this.panel1.Controls.Add(this.textBox);
			this.panel1.Controls.Add(this.startStopButton);
			this.panel1.Controls.Add(this.wpmLabel);
			this.panel1.Controls.Add(this.timeLabel);
			this.panel1.Controls.Add(this.bestWpmLabel);
			this.panel1.Controls.Add(this.wordCountLabel);
			this.panel1.Location = new System.Drawing.Point(8, 40);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(668, 352);
			this.panel1.TabIndex = 16;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
			this.ClientSize = new System.Drawing.Size(684, 400);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.minimizeButton);
			this.Controls.Add(this.maximizeButton);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.inputTextBox);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.MinimumSize = new System.Drawing.Size(700, 400);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(8);
			this.Text = "TypeFast!";
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label wpmLabel;
		private System.Windows.Forms.RichTextBox textBox;
		private System.Windows.Forms.RichTextBox inputTextBox;
		private System.Windows.Forms.Label bestWpmLabel;
		private System.Windows.Forms.Label wordCountLabel;
		private System.Windows.Forms.Button startStopButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.Button maximizeButton;
		private System.Windows.Forms.Button minimizeButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
	}
}

