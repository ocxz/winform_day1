using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _18_doYouLoveMe
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击爱我吗？ 显示信息，关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLoveMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("爱你呀，亲爱的");
            this.Close();
        }

        /// <summary>
        /// 当鼠标移到爱你妹按钮时，发生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        Random r = new Random();
        private void BtnLoveYourSis_MouseEnter(object sender, EventArgs e)
        {
            // 实时获得当前窗口宽和高
            int maxWidth = this.ClientSize.Width;
            int maxHeight = this.ClientSize.Height;

            int x = r.Next(0, maxWidth - btnLoveYourSis.Width + 1);
            int y = r.Next(0, maxHeight - btnLoveYourSis.Height + 1);

            btnLoveYourSis.Location = new Point(x, y);
        }
    }
}
