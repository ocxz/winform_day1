namespace _17_实时输入
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
            this.inputText = new System.Windows.Forms.TextBox();
            this.showLabel = new System.Windows.Forms.Label();
            this.showTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnPlayMusic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(116, 59);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(313, 21);
            this.inputText.TabIndex = 0;
            this.inputText.TextChanged += new System.EventHandler(this.TextInput_TextChanged);
            // 
            // showLabel
            // 
            this.showLabel.AutoSize = true;
            this.showLabel.Location = new System.Drawing.Point(116, 141);
            this.showLabel.Name = "showLabel";
            this.showLabel.Size = new System.Drawing.Size(89, 12);
            this.showLabel.TabIndex = 1;
            this.showLabel.Text = "即将显示的内容";
            // 
            // showTime
            // 
            this.showTime.AutoSize = true;
            this.showTime.Location = new System.Drawing.Point(330, 141);
            this.showTime.Name = "showTime";
            this.showTime.Size = new System.Drawing.Size(41, 12);
            this.showTime.TabIndex = 2;
            this.showTime.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // btnPlayMusic
            // 
            this.btnPlayMusic.Location = new System.Drawing.Point(217, 218);
            this.btnPlayMusic.Name = "btnPlayMusic";
            this.btnPlayMusic.Size = new System.Drawing.Size(75, 23);
            this.btnPlayMusic.TabIndex = 3;
            this.btnPlayMusic.Text = "播放音乐";
            this.btnPlayMusic.UseVisualStyleBackColor = true;
            this.btnPlayMusic.Click += new System.EventHandler(this.BtnPlayMusic_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPlayMusic);
            this.Controls.Add(this.showTime);
            this.Controls.Add(this.showLabel);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputText;
        private System.Windows.Forms.Label showLabel;
        private System.Windows.Forms.Label showTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnPlayMusic;
    }
}

