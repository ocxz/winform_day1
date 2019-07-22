namespace _30_记事本
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存为ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字体ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.颜色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.背景色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消换行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.显示记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.隐藏记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txRight = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 28);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 420);
            this.textBox1.TabIndex = 1;
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.另存为ToolStripMenuItem,
            this.另存为ToolStripMenuItem1});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.保存ToolStripMenuItem.Text = "打开";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem
            // 
            this.另存为ToolStripMenuItem.Name = "另存为ToolStripMenuItem";
            this.另存为ToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem.Text = "保存";
            this.另存为ToolStripMenuItem.Click += new System.EventHandler(this.另存为ToolStripMenuItem_Click);
            // 
            // 另存为ToolStripMenuItem1
            // 
            this.另存为ToolStripMenuItem1.Name = "另存为ToolStripMenuItem1";
            this.另存为ToolStripMenuItem1.Size = new System.Drawing.Size(112, 22);
            this.另存为ToolStripMenuItem1.Text = "另存为";
            this.另存为ToolStripMenuItem1.Click += new System.EventHandler(this.另存为ToolStripMenuItem1_Click);
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.字体ToolStripMenuItem,
            this.颜色ToolStripMenuItem,
            this.背景色ToolStripMenuItem,
            this.取消换行ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.格式ToolStripMenuItem.Text = "格式";
            // 
            // 字体ToolStripMenuItem
            // 
            this.字体ToolStripMenuItem.Name = "字体ToolStripMenuItem";
            this.字体ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.字体ToolStripMenuItem.Text = "字体";
            this.字体ToolStripMenuItem.Click += new System.EventHandler(this.字体ToolStripMenuItem_Click);
            // 
            // 颜色ToolStripMenuItem
            // 
            this.颜色ToolStripMenuItem.Name = "颜色ToolStripMenuItem";
            this.颜色ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.颜色ToolStripMenuItem.Text = "颜色";
            this.颜色ToolStripMenuItem.Click += new System.EventHandler(this.颜色ToolStripMenuItem_Click);
            // 
            // 背景色ToolStripMenuItem
            // 
            this.背景色ToolStripMenuItem.Name = "背景色ToolStripMenuItem";
            this.背景色ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.背景色ToolStripMenuItem.Text = "背景色";
            this.背景色ToolStripMenuItem.Click += new System.EventHandler(this.背景色ToolStripMenuItem_Click);
            // 
            // 取消换行ToolStripMenuItem
            // 
            this.取消换行ToolStripMenuItem.Name = "取消换行ToolStripMenuItem";
            this.取消换行ToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.取消换行ToolStripMenuItem.Text = "☆取消换行";
            this.取消换行ToolStripMenuItem.Click += new System.EventHandler(this.取消换行ToolStripMenuItem_Click);
            // 
            // 记录ToolStripMenuItem
            // 
            this.记录ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.显示记录ToolStripMenuItem,
            this.隐藏记录ToolStripMenuItem,
            this.清空记录ToolStripMenuItem});
            this.记录ToolStripMenuItem.Name = "记录ToolStripMenuItem";
            this.记录ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.记录ToolStripMenuItem.Text = "记录";
            // 
            // 显示记录ToolStripMenuItem
            // 
            this.显示记录ToolStripMenuItem.Name = "显示记录ToolStripMenuItem";
            this.显示记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.显示记录ToolStripMenuItem.Text = "显示记录";
            this.显示记录ToolStripMenuItem.Click += new System.EventHandler(this.显示记录ToolStripMenuItem_Click);
            // 
            // 隐藏记录ToolStripMenuItem
            // 
            this.隐藏记录ToolStripMenuItem.Name = "隐藏记录ToolStripMenuItem";
            this.隐藏记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.隐藏记录ToolStripMenuItem.Text = "隐藏记录";
            this.隐藏记录ToolStripMenuItem.Click += new System.EventHandler(this.隐藏记录ToolStripMenuItem_Click);
            // 
            // 清空记录ToolStripMenuItem
            // 
            this.清空记录ToolStripMenuItem.Name = "清空记录ToolStripMenuItem";
            this.清空记录ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.清空记录ToolStripMenuItem.Text = "清空记录";
            this.清空记录ToolStripMenuItem.Click += new System.EventHandler(this.清空记录ToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.记录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txRight);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lbLeft);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 423);
            this.panel1.TabIndex = 2;
            // 
            // txRight
            // 
            this.txRight.AcceptsReturn = true;
            this.txRight.AcceptsTab = true;
            this.txRight.Location = new System.Drawing.Point(224, 18);
            this.txRight.Multiline = true;
            this.txRight.Name = "txRight";
            this.txRight.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txRight.Size = new System.Drawing.Size(576, 376);
            this.txRight.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 120);
            this.button1.TabIndex = 2;
            this.button1.Text = "《《";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbLeft
            // 
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 12;
            this.lbLeft.Location = new System.Drawing.Point(12, 18);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(151, 376);
            this.lbLeft.TabIndex = 1;
            this.lbLeft.DoubleClick += new System.EventHandler(this.LbLeft_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件打开记录";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存为ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字体ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 颜色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 背景色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消换行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 显示记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 隐藏记录ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txRight;
        private System.Windows.Forms.ToolStripMenuItem 清空记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
    }
}

