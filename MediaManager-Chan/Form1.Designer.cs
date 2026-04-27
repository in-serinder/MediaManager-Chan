namespace MediaManager_Chan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player_wmp = new AxWMPLib.AxWindowsMediaPlayer();
            panel1 = new Panel();
            panel2 = new Panel();
            view_lb = new Label();
            playnow_lb = new Label();
            path_lb = new Label();
            open_btn = new Button();
            groupBox1 = new GroupBox();
            videores_lb = new Label();
            duration_lb = new Label();
            filesize_lb = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            sort_cb = new ComboBox();
            play_btn = new Button();
            rename_btn = new Button();
            rename_tb = new TextBox();
            del_btn = new Button();
            videolist_cb = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)player_wmp).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // player_wmp
            // 
            player_wmp.Dock = DockStyle.Right;
            player_wmp.Enabled = true;
            player_wmp.Location = new Point(404, 0);
            player_wmp.Name = "player_wmp";
            player_wmp.OcxState = (AxHost.State)resources.GetObject("player_wmp.OcxState");
            player_wmp.Size = new Size(878, 726);
            player_wmp.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(398, 726);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(view_lb);
            panel2.Controls.Add(playnow_lb);
            panel2.Controls.Add(path_lb);
            panel2.Controls.Add(open_btn);
            panel2.Location = new Point(1, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(397, 89);
            panel2.TabIndex = 0;
            // 
            // view_lb
            // 
            view_lb.AutoSize = true;
            view_lb.Location = new Point(21, 62);
            view_lb.Name = "view_lb";
            view_lb.Size = new Size(39, 20);
            view_lb.TabIndex = 3;
            view_lb.Text = "统计";
            // 
            // playnow_lb
            // 
            playnow_lb.AutoEllipsis = true;
            playnow_lb.Location = new Point(128, 9);
            playnow_lb.Name = "playnow_lb";
            playnow_lb.Size = new Size(257, 20);
            playnow_lb.TabIndex = 2;
            playnow_lb.Text = "正在播放";
            playnow_lb.UseCompatibleTextRendering = true;
            // 
            // path_lb
            // 
            path_lb.AutoEllipsis = true;
            path_lb.Location = new Point(21, 42);
            path_lb.Name = "path_lb";
            path_lb.Size = new Size(327, 20);
            path_lb.TabIndex = 1;
            path_lb.Text = "打开一个文件夹";
            path_lb.UseCompatibleTextRendering = true;
            // 
            // open_btn
            // 
            open_btn.Location = new Point(11, 0);
            open_btn.Name = "open_btn";
            open_btn.Size = new Size(118, 39);
            open_btn.TabIndex = 0;
            open_btn.Text = "打开文件夹";
            open_btn.UseVisualStyleBackColor = true;
            open_btn.Click += open_btn_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(videores_lb);
            groupBox1.Controls.Add(duration_lb);
            groupBox1.Controls.Add(filesize_lb);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(sort_cb);
            groupBox1.Controls.Add(play_btn);
            groupBox1.Controls.Add(rename_btn);
            groupBox1.Controls.Add(rename_tb);
            groupBox1.Controls.Add(del_btn);
            groupBox1.Controls.Add(videolist_cb);
            groupBox1.Location = new Point(0, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 628);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "视频列表";
            // 
            // videores_lb
            // 
            videores_lb.AutoSize = true;
            videores_lb.Location = new Point(256, 543);
            videores_lb.Name = "videores_lb";
            videores_lb.Size = new Size(39, 20);
            videores_lb.TabIndex = 10;
            videores_lb.Text = "未知";
            // 
            // duration_lb
            // 
            duration_lb.AutoSize = true;
            duration_lb.Location = new Point(129, 542);
            duration_lb.Name = "duration_lb";
            duration_lb.Size = new Size(39, 20);
            duration_lb.TabIndex = 9;
            duration_lb.Text = "未知";
            // 
            // filesize_lb
            // 
            filesize_lb.AutoSize = true;
            filesize_lb.Location = new Point(28, 542);
            filesize_lb.Name = "filesize_lb";
            filesize_lb.Size = new Size(39, 20);
            filesize_lb.TabIndex = 8;
            filesize_lb.Text = "未知";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 514);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 7;
            label4.Text = "分辨率：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(129, 514);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 6;
            label3.Text = "时长：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 514);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 4;
            label2.Text = "文件大小：";
            // 
            // sort_cb
            // 
            sort_cb.FormattingEnabled = true;
            sort_cb.Items.AddRange(new object[] { "文件大小", "a-z", "z-a" });
            sort_cb.Location = new Point(250, 566);
            sort_cb.Name = "sort_cb";
            sort_cb.Size = new Size(90, 28);
            sort_cb.TabIndex = 5;
            sort_cb.SelectedIndexChanged += sort_cb_SelectedIndexChanged;
            // 
            // play_btn
            // 
            play_btn.Location = new Point(129, 565);
            play_btn.Name = "play_btn";
            play_btn.Size = new Size(106, 27);
            play_btn.TabIndex = 4;
            play_btn.Text = "播放";
            play_btn.UseVisualStyleBackColor = true;
            play_btn.Click += play_btn_Click;
            // 
            // rename_btn
            // 
            rename_btn.Location = new Point(312, 600);
            rename_btn.Name = "rename_btn";
            rename_btn.Size = new Size(74, 29);
            rename_btn.TabIndex = 3;
            rename_btn.Text = "重命名";
            rename_btn.UseVisualStyleBackColor = true;
            rename_btn.Click += rename_btn_Click;
            // 
            // rename_tb
            // 
            rename_tb.Location = new Point(6, 598);
            rename_tb.Name = "rename_tb";
            rename_tb.Size = new Size(300, 27);
            rename_tb.TabIndex = 2;
            // 
            // del_btn
            // 
            del_btn.BackColor = Color.Gainsboro;
            del_btn.ForeColor = Color.Red;
            del_btn.Location = new Point(6, 565);
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(106, 27);
            del_btn.TabIndex = 1;
            del_btn.Text = "删除";
            del_btn.UseVisualStyleBackColor = false;
            del_btn.Click += del_btn_Click;
            // 
            // videolist_cb
            // 
            videolist_cb.Dock = DockStyle.Top;
            videolist_cb.FormattingEnabled = true;
            videolist_cb.HorizontalScrollbar = true;
            videolist_cb.Location = new Point(3, 23);
            videolist_cb.Name = "videolist_cb";
            videolist_cb.Size = new Size(392, 488);
            videolist_cb.TabIndex = 0;
            videolist_cb.SelectedIndexChanged += videolist_cb_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1282, 726);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(player_wmp);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Form1";
            Text = "MediaManager-Chan";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)player_wmp).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player_wmp;
        private Panel panel1;
        private Panel panel2;
        private Label path_lb;
        private Button open_btn;
        private GroupBox groupBox1;
        private Button rename_btn;
        private TextBox rename_tb;
        private Button del_btn;
        private CheckedListBox videolist_cb;
        private Label playnow_lb;
        private Button play_btn;
        private ComboBox sort_cb;
        private Label view_lb;
        private Label filesize_lb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label videores_lb;
        private Label duration_lb;
    }
}
