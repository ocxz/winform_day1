using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_多个窗体
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击关闭窗体2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseF2_Click(object sender, EventArgs e)
        {
            Form2.GetForm().Close();
        }

        /// <summary>
        /// 点击关闭窗体1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCloseF1_Click(object sender, EventArgs e)
        {
            Form1.form1.Close();
        }
    }
}
