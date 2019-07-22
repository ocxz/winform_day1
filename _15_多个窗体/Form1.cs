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
    public partial class Form1 : Form
    {
        // 设置一个静态变量，用于存储Form1对象
        public static Form1 form1;

        /// <summary>
        /// 单例设计模式，饿汉式
        /// </summary>
        private static Form1 form = new Form1();



        private Form1()
        {
            InitializeComponent();
        }
        public static Form1 GetForm()
        {
            form1 = form;
            return form;
        }


        /// <summary>
        /// 点击按钮，创建窗口form2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            Form form2 = Form2.GetForm();
            form2.Show();
        }
    }
}
