namespace _学生Or老师
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
            this.unLabel = new System.Windows.Forms.Label();
            this.unPwd = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.TextBox();
            this.uPwd = new System.Windows.Forms.TextBox();
            this.rbStudent = new System.Windows.Forms.RadioButton();
            this.rbTeacher = new System.Windows.Forms.RadioButton();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.rbAdmin = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // unLabel
            // 
            this.unLabel.AutoSize = true;
            this.unLabel.Location = new System.Drawing.Point(175, 58);
            this.unLabel.Name = "unLabel";
            this.unLabel.Size = new System.Drawing.Size(53, 12);
            this.unLabel.TabIndex = 0;
            this.unLabel.Text = "用户名：";
            // 
            // unPwd
            // 
            this.unPwd.AutoSize = true;
            this.unPwd.Location = new System.Drawing.Point(175, 116);
            this.unPwd.Name = "unPwd";
            this.unPwd.Size = new System.Drawing.Size(47, 12);
            this.unPwd.TabIndex = 1;
            this.unPwd.Text = "密 码：";
            // 
            // uName
            // 
            this.uName.Location = new System.Drawing.Point(234, 55);
            this.uName.Name = "uName";
            this.uName.Size = new System.Drawing.Size(236, 21);
            this.uName.TabIndex = 2;
            // 
            // uPwd
            // 
            this.uPwd.Location = new System.Drawing.Point(234, 107);
            this.uPwd.Name = "uPwd";
            this.uPwd.PasswordChar = '*';
            this.uPwd.Size = new System.Drawing.Size(236, 21);
            this.uPwd.TabIndex = 3;
            // 
            // rbStudent
            // 
            this.rbStudent.AutoSize = true;
            this.rbStudent.Checked = true;
            this.rbStudent.Location = new System.Drawing.Point(234, 177);
            this.rbStudent.Name = "rbStudent";
            this.rbStudent.Size = new System.Drawing.Size(47, 16);
            this.rbStudent.TabIndex = 4;
            this.rbStudent.TabStop = true;
            this.rbStudent.Text = "学生";
            this.rbStudent.UseVisualStyleBackColor = true;
            // 
            // rbTeacher
            // 
            this.rbTeacher.AutoSize = true;
            this.rbTeacher.Location = new System.Drawing.Point(320, 177);
            this.rbTeacher.Name = "rbTeacher";
            this.rbTeacher.Size = new System.Drawing.Size(47, 16);
            this.rbTeacher.TabIndex = 5;
            this.rbTeacher.Text = "老师";
            this.rbTeacher.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(234, 233);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 23);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(365, 233);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 23);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "取消";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // rbAdmin
            // 
            this.rbAdmin.AutoSize = true;
            this.rbAdmin.Location = new System.Drawing.Point(411, 177);
            this.rbAdmin.Name = "rbAdmin";
            this.rbAdmin.Size = new System.Drawing.Size(59, 16);
            this.rbAdmin.TabIndex = 8;
            this.rbAdmin.Text = "管理员";
            this.rbAdmin.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rbAdmin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.rbTeacher);
            this.Controls.Add(this.rbStudent);
            this.Controls.Add(this.uPwd);
            this.Controls.Add(this.uName);
            this.Controls.Add(this.unPwd);
            this.Controls.Add(this.unLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label unLabel;
        private System.Windows.Forms.Label unPwd;
        private System.Windows.Forms.TextBox uName;
        private System.Windows.Forms.TextBox uPwd;
        private System.Windows.Forms.RadioButton rbStudent;
        private System.Windows.Forms.RadioButton rbTeacher;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.RadioButton rbAdmin;
    }
}

