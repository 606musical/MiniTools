namespace Minitools
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ts1 = new ToolStripMenuItem();
            ts2 = new ToolStripMenuItem();
            ts3 = new ToolStripMenuItem();
            ts4 = new ToolStripMenuItem();
            ts41 = new ToolStripMenuItem();
            ts42 = new ToolStripMenuItem();
            ts5 = new ToolStripMenuItem();
            ts51 = new ToolStripComboBox();
            ts52 = new ToolStripMenuItem();
            ts53 = new ToolStripMenuItem();
            ts54 = new ToolStripMenuItem();
            ts6 = new ToolStripMenuItem();
            ts7 = new ToolStripMenuItem();
            ts8 = new ToolStripMenuItem();
            ts9 = new ToolStripMenuItem();
            ts0 = new ToolStripMenuItem();
            ts01 = new ToolStripMenuItem();
            ts02 = new ToolStripMenuItem();
            ts03 = new ToolStripMenuItem();
            ts031 = new ToolStripMenuItem();
            ts032 = new ToolStripMenuItem();
            ts033 = new ToolStripMenuItem();
            ts04 = new ToolStripMenuItem();
            ts041 = new ToolStripMenuItem();
            ts042 = new ToolStripMenuItem();
            ts043 = new ToolStripMenuItem();
            ts05 = new ToolStripMenuItem();
            ts06 = new ToolStripMenuItem();
            timer1 = new System.Windows.Forms.Timer(components);
            label9 = new Label();
            label11 = new Label();
            colorDialog1 = new ColorDialog();
            label17 = new Label();
            fontDialog = new FontDialog();
            progressBar2 = new ProgressBar();
            label10 = new Label();
            toolStripMenuItem3 = new ToolStripMenuItem();
            label18 = new Label();
            timer5 = new System.Windows.Forms.Timer(components);
            timer4 = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.BackColor = SystemColors.Control;
            contextMenuStrip1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ts1, ts2, ts3, ts4, ts5, ts6, ts7, ts8, ts9, ts0 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.RenderMode = ToolStripRenderMode.System;
            contextMenuStrip1.ShowImageMargin = false;
            contextMenuStrip1.Size = new Size(195, 246);
            contextMenuStrip1.Text = "select";
            // 
            // ts1
            // 
            ts1.Name = "ts1";
            ts1.ShortcutKeys = Keys.Alt | Keys.C;
            ts1.Size = new Size(194, 22);
            ts1.Text = "control Panel (win)";
            ts1.Click += tsmic6;
            ts1.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts1.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts2
            // 
            ts2.Name = "ts2";
            ts2.ShortcutKeys = Keys.Alt | Keys.E;
            ts2.Size = new Size(194, 22);
            ts2.Text = "Explorer (Folder)";
            ts2.Click += tsmic7;
            ts2.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts2.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts3
            // 
            ts3.Name = "ts3";
            ts3.Size = new Size(194, 22);
            ts3.Text = "Color picker";
            ts3.Click += Label1_DoubleClick;
            ts3.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts3.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts4
            // 
            ts4.DropDownItems.AddRange(new ToolStripItem[] { ts41, ts42 });
            ts4.Name = "ts4";
            ts4.ShortcutKeys = Keys.Alt | Keys.O;
            ts4.Size = new Size(194, 22);
            ts4.Text = "Display suspend";
            ts4.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts4.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts41
            // 
            ts41.Name = "ts41";
            ts41.Size = new Size(100, 22);
            ts41.Text = "1min";
            ts41.Click += ts70_Click;
            ts41.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts41.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts42
            // 
            ts42.Name = "ts42";
            ts42.Size = new Size(100, 22);
            ts42.Text = "3min";
            ts42.Click += ts71_Click;
            ts42.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts42.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts5
            // 
            ts5.DropDownItems.AddRange(new ToolStripItem[] { ts51, ts52, ts53, ts54 });
            ts5.Name = "ts5";
            ts5.Size = new Size(194, 22);
            ts5.Text = "active Window by Mouse";
            // 
            // ts51
            // 
            ts51.AutoCompleteCustomSource.AddRange(new string[] { "500", "400", "300", "200", "100", "50", "0" });
            ts51.Items.AddRange(new object[] { "500", "400", "300", "200", "100", "50", "0" });
            ts51.Name = "ts51";
            ts51.Size = new Size(121, 23);
            ts51.SelectedIndexChanged += ToolStripComboBox1_SelectedIndexChanged;
            // 
            // ts52
            // 
            ts52.Name = "ts52";
            ts52.Size = new Size(183, 22);
            ts52.Text = "ResponseSPD 500 - 0";
            // 
            // ts53
            // 
            ts53.Name = "ts53";
            ts53.Size = new Size(183, 22);
            ts53.Text = "ON";
            ts53.Click += ts52_Click;
            // 
            // ts54
            // 
            ts54.Name = "ts54";
            ts54.Size = new Size(183, 22);
            ts54.Text = "OFF";
            ts54.Click += ts53_Click;
            // 
            // ts6
            // 
            ts6.Name = "ts6";
            ts6.Size = new Size(194, 22);
            ts6.Text = "Windw move ON";
            ts6.Click += ts17A_Click;
            // 
            // ts7
            // 
            ts7.Name = "ts7";
            ts7.Size = new Size(194, 22);
            ts7.Text = "Minimaize";
            ts7.Click += ToolStripMenuItem11_Click_1;
            ts7.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts7.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts8
            // 
            ts8.Name = "ts8";
            ts8.ShortcutKeys = Keys.Control | Keys.Alt | Keys.Space;
            ts8.Size = new Size(194, 22);
            ts8.Text = "Close";
            ts8.Click += tsmicC;
            ts8.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts8.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts9
            // 
            ts9.Name = "ts9";
            ts9.ShortcutKeyDisplayString = "";
            ts9.ShortcutKeys = Keys.Alt | Keys.Space;
            ts9.Size = new Size(194, 22);
            ts9.Text = "Close this Menu";
            ts9.Click += ToolStripMenuItem5_Click;
            ts9.MouseEnter += ToolStripMenuItem7_MouseEnter_1;
            ts9.MouseLeave += ToolStripMenuItem7_MouseLeave;
            // 
            // ts0
            // 
            ts0.DropDownItems.AddRange(new ToolStripItem[] { ts01, ts02, ts03, ts04, ts05, ts06 });
            ts0.Name = "ts0";
            ts0.Size = new Size(194, 22);
            ts0.Text = "Display Related";
            // 
            // ts01
            // 
            ts01.Name = "ts01";
            ts01.Size = new Size(192, 22);
            ts01.Text = "Dark mode";
            ts01.Click += ts18_Click;
            // 
            // ts02
            // 
            ts02.Name = "ts02";
            ts02.Size = new Size(192, 22);
            ts02.Text = "Light mode";
            ts02.Click += ts02_Click;
            // 
            // ts03
            // 
            ts03.DropDownItems.AddRange(new ToolStripItem[] { ts031, ts032, ts033 });
            ts03.Name = "ts03";
            ts03.Size = new Size(192, 22);
            ts03.Text = "Font , Color";
            // 
            // ts031
            // 
            ts031.Name = "ts031";
            ts031.Size = new Size(142, 22);
            ts031.Text = "Color select";
            ts031.Click += ctsmic;
            // 
            // ts032
            // 
            ts032.Name = "ts032";
            ts032.Size = new Size(142, 22);
            ts032.Text = "Font select";
            ts032.Click += ts932_Click;
            // 
            // ts033
            // 
            ts033.Name = "ts033";
            ts033.Size = new Size(142, 22);
            ts033.Text = "initial setting";
            ts033.Click += ts933_Click;
            // 
            // ts04
            // 
            ts04.DropDownItems.AddRange(new ToolStripItem[] { ts041, ts042, ts043 });
            ts04.Name = "ts04";
            ts04.Size = new Size(192, 22);
            ts04.Text = "Skin select";
            // 
            // ts041
            // 
            ts041.Name = "ts041";
            ts041.Size = new Size(191, 22);
            ts041.Text = "- Window frame -";
            ts041.Click += ts901_Click;
            // 
            // ts042
            // 
            ts042.Name = "ts042";
            ts042.Size = new Size(191, 22);
            ts042.Text = "square (win10 , win11)";
            ts042.Click += ts912_Click;
            // 
            // ts043
            // 
            ts043.Name = "ts043";
            ts043.Size = new Size(191, 22);
            ts043.Text = "circle (win11only)";
            ts043.Click += ts922_Click;
            // 
            // ts05
            // 
            ts05.BackColor = SystemColors.Control;
            ts05.ForeColor = SystemColors.ControlText;
            ts05.Name = "ts05";
            ts05.Size = new Size(192, 22);
            ts05.Text = "Transparent display on";
            ts05.Click += ts05_Click;
            // 
            // ts06
            // 
            ts06.Name = "ts06";
            ts06.Size = new Size(192, 22);
            ts06.Text = "Transparent display off";
            ts06.Click += ts06_Click;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += Timer1_Tick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.FlatStyle = FlatStyle.Popup;
            label9.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label9.Location = new Point(4, 6);
            label9.Margin = new Padding(0);
            label9.Name = "label9";
            label9.Size = new Size(51, 16);
            label9.TabIndex = 28;
            label9.Text = "label9";
            label9.DoubleClick += Label1_DoubleClick;
            label9.MouseDown += Form1_MouseDown;
            label9.MouseMove += Form1_MouseMove;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS UI Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 128);
            label11.Location = new Point(74, 6);
            label11.Name = "label11";
            label11.Size = new Size(60, 16);
            label11.TabIndex = 30;
            label11.Text = "label11";
            label11.MouseDown += Form1_MouseDown;
            label11.MouseMove += Form1_MouseMove;
            // 
            // colorDialog1
            // 
            colorDialog1.AnyColor = true;
            colorDialog1.FullOpen = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("MS UI Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label17.Location = new Point(157, 8);
            label17.Name = "label17";
            label17.Size = new Size(15, 13);
            label17.TabIndex = 38;
            label17.Text = "R";
            label17.TextAlign = ContentAlignment.TopRight;
            // 
            // fontDialog
            // 
            fontDialog.ShowApply = true;
            // 
            // progressBar2
            // 
            progressBar2.BackColor = SystemColors.Control;
            progressBar2.ForeColor = Color.Transparent;
            progressBar2.Location = new Point(5, 24);
            progressBar2.Margin = new Padding(0);
            progressBar2.Name = "progressBar2";
            progressBar2.RightToLeft = RightToLeft.Yes;
            progressBar2.RightToLeftLayout = true;
            progressBar2.Size = new Size(170, 1);
            progressBar2.Step = 1;
            progressBar2.Style = ProgressBarStyle.Continuous;
            progressBar2.TabIndex = 40;
            progressBar2.Value = 100;
            progressBar2.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.Popup;
            label10.Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            label10.Location = new Point(58, 8);
            label10.MaximumSize = new Size(30, 0);
            label10.MinimumSize = new Size(25, 0);
            label10.Name = "label10";
            label10.Size = new Size(25, 12);
            label10.TabIndex = 29;
            label10.Text = "sun";
            label10.MouseDown += Form1_MouseDown;
            label10.MouseMove += Form1_MouseMove;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(32, 19);
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Location = new Point(8, 33);
            label18.Name = "label18";
            label18.Size = new Size(41, 12);
            label18.TabIndex = 42;
            label18.Text = "label18";
            // 
            // timer5
            // 
            timer5.Tick += timer5_Tick;
            // 
            // timer4
            // 
            timer4.Interval = 1000;
            timer4.Tick += Timer4_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(162, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(10, 10);
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 12F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Magenta;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(180, 52);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(progressBar2);
            Controls.Add(label17);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label18);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Font = new Font("MS UI Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 128);
            ForeColor = Color.FromArgb(64, 64, 64);
            FormBorderStyle = FormBorderStyle.None;
            KeyPreview = true;
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            MaximumSize = new Size(180, 52);
            MinimizeBox = false;
            MinimumSize = new Size(180, 28);
            Name = "Form1";
            Text = "smallclock";
            TopMost = true;
            Activated += Form1_Activated;
            Deactivate += Form1_Deactivate;
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            DoubleClick += Label1_DoubleClick;
            MouseDown += Form1_MouseDown;
            MouseLeave += Form1_MouseLeave;
            MouseMove += Form1_MouseMove;
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ToolStripMenuItem ts8;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ts1;
        private System.Windows.Forms.ToolStripMenuItem ts2;
        private System.Windows.Forms.ToolStripMenuItem ts9;
        private System.Windows.Forms.ToolStripMenuItem ts4;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ToolStripMenuItem ts3;
        private System.Windows.Forms.ToolStripMenuItem ts7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer5;
        public System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStripMenuItem ts41;
        private System.Windows.Forms.ToolStripMenuItem ts42;
        private System.Windows.Forms.Timer timer4;
        private System.Windows.Forms.ToolStripMenuItem ts0;
        private System.Windows.Forms.ToolStripMenuItem ts01;
        private System.Windows.Forms.ToolStripMenuItem ts02;
        private System.Windows.Forms.ToolStripMenuItem ts03;
        private System.Windows.Forms.ToolStripMenuItem ts031;
        private System.Windows.Forms.ToolStripMenuItem ts032;
        private System.Windows.Forms.ToolStripMenuItem ts033;
        private System.Windows.Forms.ToolStripMenuItem ts5;
        internal System.Windows.Forms.ToolStripComboBox ts51;
        private System.Windows.Forms.ToolStripMenuItem ts52;
        private System.Windows.Forms.ToolStripMenuItem ts53;
        private System.Windows.Forms.ToolStripMenuItem ts54;
        private System.Windows.Forms.ToolStripMenuItem ts6;
        private System.Windows.Forms.ToolStripMenuItem ts04;
        private System.Windows.Forms.ToolStripMenuItem ts041;
        private System.Windows.Forms.ToolStripMenuItem ts042;
        private System.Windows.Forms.ToolStripMenuItem ts043;
        private System.Windows.Forms.ToolStripMenuItem ts05;
        private System.Windows.Forms.ToolStripMenuItem ts06;
        public FontDialog fontDialog;
    }
}

