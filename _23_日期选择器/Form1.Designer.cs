namespace _23_日期选择器
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
            this.cobYear = new System.Windows.Forms.ComboBox();
            this.cobMonth = new System.Windows.Forms.ComboBox();
            this.cobDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cobYear
            // 
            this.cobYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobYear.FormattingEnabled = true;
            this.cobYear.Location = new System.Drawing.Point(69, 95);
            this.cobYear.Name = "cobYear";
            this.cobYear.Size = new System.Drawing.Size(121, 20);
            this.cobYear.TabIndex = 0;
            this.cobYear.SelectedIndexChanged += new System.EventHandler(this.CobYear_SelectedIndexChanged);
            // 
            // cobMonth
            // 
            this.cobMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobMonth.FormattingEnabled = true;
            this.cobMonth.Location = new System.Drawing.Point(303, 95);
            this.cobMonth.Name = "cobMonth";
            this.cobMonth.Size = new System.Drawing.Size(121, 20);
            this.cobMonth.TabIndex = 1;
            this.cobMonth.SelectedIndexChanged += new System.EventHandler(this.CobMonth_SelectedIndexChanged);
            // 
            // cobDay
            // 
            this.cobDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cobDay.FormattingEnabled = true;
            this.cobDay.Location = new System.Drawing.Point(524, 95);
            this.cobDay.Name = "cobDay";
            this.cobDay.Size = new System.Drawing.Size(121, 20);
            this.cobDay.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cobDay);
            this.Controls.Add(this.cobMonth);
            this.Controls.Add(this.cobYear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cobYear;
        private System.Windows.Forms.ComboBox cobMonth;
        private System.Windows.Forms.ComboBox cobDay;
    }
}

