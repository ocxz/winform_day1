namespace _24_TreeView控件
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
            System.Windows.Forms.TreeNode treeNode31 = new System.Windows.Forms.TreeNode("D:\\");
            System.Windows.Forms.TreeNode treeNode32 = new System.Windows.Forms.TreeNode("C:\\");
            System.Windows.Forms.TreeNode treeNode33 = new System.Windows.Forms.TreeNode("我的电脑", new System.Windows.Forms.TreeNode[] {
            treeNode31,
            treeNode32});
            System.Windows.Forms.TreeNode treeNode34 = new System.Windows.Forms.TreeNode("节点3");
            System.Windows.Forms.TreeNode treeNode35 = new System.Windows.Forms.TreeNode("网络邻居", new System.Windows.Forms.TreeNode[] {
            treeNode34});
            System.Windows.Forms.TreeNode treeNode36 = new System.Windows.Forms.TreeNode("回收站");
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("我的图片");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("我的音乐");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("我的下载");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("我的文档", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txParent = new System.Windows.Forms.TextBox();
            this.txChild = new System.Windows.Forms.TextBox();
            this.tbnParent = new System.Windows.Forms.Button();
            this.btnChild = new System.Windows.Forms.Button();
            this.btnOpenAll = new System.Windows.Forms.Button();
            this.btnCloseAll = new System.Windows.Forms.Button();
            this.txUpdata = new System.Windows.Forms.TextBox();
            this.btnUpdata = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(86, 28);
            this.treeView1.Name = "treeView1";
            treeNode31.Name = "节点1";
            treeNode31.Text = "D:\\";
            treeNode32.Name = "节点7";
            treeNode32.Text = "C:\\";
            treeNode33.Name = "节点0";
            treeNode33.Text = "我的电脑";
            treeNode34.Name = "节点3";
            treeNode34.Text = "节点3";
            treeNode35.Name = "节点2";
            treeNode35.Text = "网络邻居";
            treeNode36.Name = "节点4";
            treeNode36.Text = "回收站";
            treeNode37.Name = "节点8";
            treeNode37.Text = "我的图片";
            treeNode38.Name = "节点9";
            treeNode38.Text = "我的音乐";
            treeNode39.Name = "节点10";
            treeNode39.Text = "我的下载";
            treeNode40.Name = "节点5";
            treeNode40.Text = "我的文档";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode33,
            treeNode35,
            treeNode36,
            treeNode40});
            this.treeView1.Size = new System.Drawing.Size(190, 396);
            this.treeView1.TabIndex = 0;
            // 
            // txParent
            // 
            this.txParent.Location = new System.Drawing.Point(340, 28);
            this.txParent.Name = "txParent";
            this.txParent.Size = new System.Drawing.Size(174, 21);
            this.txParent.TabIndex = 1;
            // 
            // txChild
            // 
            this.txChild.Location = new System.Drawing.Point(340, 134);
            this.txChild.Name = "txChild";
            this.txChild.Size = new System.Drawing.Size(174, 21);
            this.txChild.TabIndex = 2;
            // 
            // tbnParent
            // 
            this.tbnParent.Location = new System.Drawing.Point(340, 74);
            this.tbnParent.Name = "tbnParent";
            this.tbnParent.Size = new System.Drawing.Size(141, 23);
            this.tbnParent.TabIndex = 3;
            this.tbnParent.Text = "添加根节点";
            this.tbnParent.UseVisualStyleBackColor = true;
            this.tbnParent.Click += new System.EventHandler(this.TbnParent_Click);
            // 
            // btnChild
            // 
            this.btnChild.Location = new System.Drawing.Point(340, 195);
            this.btnChild.Name = "btnChild";
            this.btnChild.Size = new System.Drawing.Size(141, 23);
            this.btnChild.TabIndex = 4;
            this.btnChild.Text = "添加子节点";
            this.btnChild.UseVisualStyleBackColor = true;
            this.btnChild.Click += new System.EventHandler(this.BtnChild_Click);
            // 
            // btnOpenAll
            // 
            this.btnOpenAll.Location = new System.Drawing.Point(340, 365);
            this.btnOpenAll.Name = "btnOpenAll";
            this.btnOpenAll.Size = new System.Drawing.Size(82, 23);
            this.btnOpenAll.TabIndex = 5;
            this.btnOpenAll.Text = "展开所有";
            this.btnOpenAll.UseVisualStyleBackColor = true;
            this.btnOpenAll.Click += new System.EventHandler(this.BtnOpenAll_Click);
            // 
            // btnCloseAll
            // 
            this.btnCloseAll.Location = new System.Drawing.Point(439, 365);
            this.btnCloseAll.Name = "btnCloseAll";
            this.btnCloseAll.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAll.TabIndex = 6;
            this.btnCloseAll.Text = "折叠所有";
            this.btnCloseAll.UseVisualStyleBackColor = true;
            this.btnCloseAll.Click += new System.EventHandler(this.BtnCloseAll_Click);
            // 
            // txUpdata
            // 
            this.txUpdata.Location = new System.Drawing.Point(340, 249);
            this.txUpdata.Name = "txUpdata";
            this.txUpdata.Size = new System.Drawing.Size(174, 21);
            this.txUpdata.TabIndex = 7;
            // 
            // btnUpdata
            // 
            this.btnUpdata.Location = new System.Drawing.Point(340, 294);
            this.btnUpdata.Name = "btnUpdata";
            this.btnUpdata.Size = new System.Drawing.Size(141, 23);
            this.btnUpdata.TabIndex = 8;
            this.btnUpdata.Text = "修改名称";
            this.btnUpdata.UseVisualStyleBackColor = true;
            this.btnUpdata.Click += new System.EventHandler(this.BtnUpdata_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(537, 365);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "删除节点";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdata);
            this.Controls.Add(this.txUpdata);
            this.Controls.Add(this.btnCloseAll);
            this.Controls.Add(this.btnOpenAll);
            this.Controls.Add(this.btnChild);
            this.Controls.Add(this.tbnParent);
            this.Controls.Add(this.txChild);
            this.Controls.Add(this.txParent);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txParent;
        private System.Windows.Forms.TextBox txChild;
        private System.Windows.Forms.Button tbnParent;
        private System.Windows.Forms.Button btnChild;
        private System.Windows.Forms.Button btnOpenAll;
        private System.Windows.Forms.Button btnCloseAll;
        private System.Windows.Forms.TextBox txUpdata;
        private System.Windows.Forms.Button btnUpdata;
        private System.Windows.Forms.Button btnDelete;
    }
}

