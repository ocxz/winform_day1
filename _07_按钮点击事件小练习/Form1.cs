using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_按钮点击事件小练习
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击第一个按钮时，第二个按钮颜色变为绿色 第一个按钮不可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            // 点击第一个按钮时，第二个按钮颜色变为绿色 第一个按钮不可用

            btnTwo.Visible = true;
            btnThree.Visible = false;
            btnTwo.BackColor = Color.Green;   // 第二个按钮背景颜色变绿
            btnOne.Enabled = false;   // 第一个按钮不可用
        }

        /// <summary>
        /// 点击第二个按钮时，第三个按钮出现了 颜色为红色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button2_Click(object sender, EventArgs e)
        {
            // 点击第二个按钮时，第三个按钮出现了 颜色为红色

            btnThree.Show();   // 显示第三个按钮
            btnThree.BackColor = Color.Red;   // 颜色为红色

        }

        /// <summary>
        /// 点击第三个按钮 第二个按钮消失 第一个按钮可用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button3_Click(object sender, EventArgs e)
        {
            // 点击第三个按钮 第二个按钮消失 第一个按钮可用

            btnTwo.Visible = false;
            btnOne.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
