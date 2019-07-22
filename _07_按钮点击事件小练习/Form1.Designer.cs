namespace _07_按钮点击事件小练习
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
            this.btnOne = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(197, 90);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(110, 67);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "按钮一";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.Location = new System.Drawing.Point(389, 90);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(107, 67);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "按钮二";
            this.btnTwo.UseVisualStyleBackColor = true;
            this.btnTwo.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btnThree
            // 
            this.btnThree.Location = new System.Drawing.Point(559, 90);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(111, 67);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "按钮三";
            this.btnThree.UseVisualStyleBackColor = true;
            this.btnThree.Visible = false;
            this.btnThree.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 478);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
    }
}

