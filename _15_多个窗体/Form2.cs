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
    public partial class Form2 : Form
    {
        /// <summary>
        /// 用单例设计模式，创建form2对象  懒汉设计模式
        /// </summary>
        private static Form2 form;
        private Form2()
        {
            InitializeComponent();
        }
        public static Form2 GetForm()
        {
            if (form == null)
            {
                form = new Form2();
            }
            return form;
        }

        /// <summary>
        /// 点击，关闭窗口1 所有窗口关闭 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Form1.form1.Close();
        }

        /// <summary>
        /// 点击创建窗体3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
    }
}
