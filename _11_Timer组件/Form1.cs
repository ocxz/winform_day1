using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11_Timer组件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 一秒将触发一次，每个一秒钟将窗体的透明的加10%
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private int flag = 1;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity == 0 || this.Opacity == 1)   //  达到边界时，加减调换
            {
                flag *= -1;
            }

            this.Opacity += 0.1 * flag;
        }
    }
}
