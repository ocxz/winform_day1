using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_事件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击按钮时，触发事件，执行此方法
        /// </summary>
        /// <param name="sender">被触发事件对象</param>
        /// <param name="e"></param>
        private void BtnClick_Click(object sender, EventArgs e)
        {
            //Button btn = (Button)sender;
            MessageBox.Show("我被点击了");

        }
    }
}
