namespace _18_doYouLoveMe
{
    partial class form1
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
            this.btnLoveMe = new System.Windows.Forms.Button();
            this.btnLoveYourSis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoveMe
            // 
            this.btnLoveMe.Location = new System.Drawing.Point(133, 148);
            this.btnLoveMe.Name = "btnLoveMe";
            this.btnLoveMe.Size = new System.Drawing.Size(75, 23);
            this.btnLoveMe.TabIndex = 0;
            this.btnLoveMe.Text = "爱我吗？";
            this.btnLoveMe.UseVisualStyleBackColor = true;
            this.btnLoveMe.Click += new System.EventHandler(this.BtnLoveMe_Click);
            // 
            // btnLoveYourSis
            // 
            this.btnLoveYourSis.Location = new System.Drawing.Point(445, 147);
            this.btnLoveYourSis.Name = "btnLoveYourSis";
            this.btnLoveYourSis.Size = new System.Drawing.Size(75, 23);
            this.btnLoveYourSis.TabIndex = 1;
            this.btnLoveYourSis.Text = "爱你妹";
            this.btnLoveYourSis.UseVisualStyleBackColor = true;
            this.btnLoveYourSis.MouseEnter += new System.EventHandler(this.BtnLoveYourSis_MouseEnter);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLoveYourSis);
            this.Controls.Add(this.btnLoveMe);
            this.Name = "form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoveMe;
        private System.Windows.Forms.Button btnLoveYourSis;
    }
}

