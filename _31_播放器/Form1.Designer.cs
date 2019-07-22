namespace _31_播放器
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbNoMusic = new System.Windows.Forms.Label();
            this.listBoxMusic = new System.Windows.Forms.ListBox();
            this.cmsMusecList = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.添加至列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.从列表删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空列表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.播放ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.curMusicName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmsMusecList.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(40, 42);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(652, 385);
            this.musicPlayer.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lbNoMusic);
            this.panel1.Controls.Add(this.listBoxMusic);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(712, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 385);
            this.panel1.TabIndex = 1;
            // 
            // lbNoMusic
            // 
            this.lbNoMusic.AutoSize = true;
            this.lbNoMusic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lbNoMusic.Font = new System.Drawing.Font("华文细黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbNoMusic.Location = new System.Drawing.Point(38, 183);
            this.lbNoMusic.Name = "lbNoMusic";
            this.lbNoMusic.Size = new System.Drawing.Size(86, 21);
            this.lbNoMusic.TabIndex = 2;
            this.lbNoMusic.Text = "暂无播放";
            // 
            // listBoxMusic
            // 
            this.listBoxMusic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.listBoxMusic.ContextMenuStrip = this.cmsMusecList;
            this.listBoxMusic.Font = new System.Drawing.Font("宋体", 12F);
            this.listBoxMusic.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBoxMusic.FormattingEnabled = true;
            this.listBoxMusic.HorizontalScrollbar = true;
            this.listBoxMusic.ItemHeight = 16;
            this.listBoxMusic.Location = new System.Drawing.Point(8, 35);
            this.listBoxMusic.Name = "listBoxMusic";
            this.listBoxMusic.Size = new System.Drawing.Size(147, 340);
            this.listBoxMusic.TabIndex = 1;
            this.listBoxMusic.SelectedIndexChanged += new System.EventHandler(this.ListBoxMusic_SelectedIndexChanged);
            this.listBoxMusic.DoubleClick += new System.EventHandler(this.ListBoxMusic_DoubleClick);
            // 
            // cmsMusecList
            // 
            this.cmsMusecList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加至列表ToolStripMenuItem,
            this.从列表删除ToolStripMenuItem,
            this.清空列表ToolStripMenuItem,
            this.播放ToolStripMenuItem});
            this.cmsMusecList.Name = "contextMenuStrip1";
            this.cmsMusecList.Size = new System.Drawing.Size(137, 92);
            // 
            // 添加至列表ToolStripMenuItem
            // 
            this.添加至列表ToolStripMenuItem.Name = "添加至列表ToolStripMenuItem";
            this.添加至列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.添加至列表ToolStripMenuItem.Text = "添加至列表";
            this.添加至列表ToolStripMenuItem.Click += new System.EventHandler(this.添加至列表ToolStripMenuItem_Click);
            // 
            // 从列表删除ToolStripMenuItem
            // 
            this.从列表删除ToolStripMenuItem.Name = "从列表删除ToolStripMenuItem";
            this.从列表删除ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.从列表删除ToolStripMenuItem.Text = "删除";
            this.从列表删除ToolStripMenuItem.Click += new System.EventHandler(this.从列表删除ToolStripMenuItem_Click);
            // 
            // 清空列表ToolStripMenuItem
            // 
            this.清空列表ToolStripMenuItem.Name = "清空列表ToolStripMenuItem";
            this.清空列表ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.清空列表ToolStripMenuItem.Text = "清空列表";
            this.清空列表ToolStripMenuItem.Click += new System.EventHandler(this.清空列表ToolStripMenuItem_Click);
            // 
            // 播放ToolStripMenuItem
            // 
            this.播放ToolStripMenuItem.Name = "播放ToolStripMenuItem";
            this.播放ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.播放ToolStripMenuItem.Text = "播放";
            this.播放ToolStripMenuItem.Click += new System.EventHandler(this.播放ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "--------播放列表--------\r\n";
            // 
            // curMusicName
            // 
            this.curMusicName.AutoSize = true;
            this.curMusicName.Location = new System.Drawing.Point(346, 13);
            this.curMusicName.Name = "curMusicName";
            this.curMusicName.Size = new System.Drawing.Size(41, 12);
            this.curMusicName.TabIndex = 2;
            this.curMusicName.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 500);
            this.Controls.Add(this.curMusicName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.musicPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsMusecList.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNoMusic;
        private System.Windows.Forms.ListBox listBoxMusic;
        private System.Windows.Forms.ContextMenuStrip cmsMusecList;
        private System.Windows.Forms.ToolStripMenuItem 添加至列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 从列表删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空列表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 播放ToolStripMenuItem;
        private System.Windows.Forms.Label curMusicName;
    }
}

