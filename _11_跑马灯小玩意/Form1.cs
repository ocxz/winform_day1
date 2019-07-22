using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_跑马灯小玩意
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 每个0.1秒执行一次  5 4 3 2 1==》1 5 4 3 2  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            // 每次把最后一个字符截出来，在加上前面的4个
            string text = label1.Text;

            // 相当于："1 "+"5 4 3 2"
            label1.Text = text.Substring(text.Length - 1) + text.Substring(0, text.Length - 1);
        }
    }
}
