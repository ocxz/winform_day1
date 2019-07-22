using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_点击查看图片
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==13)
            {
                string inputStr = input.Text;
                int age = DateTime.Now.Year - int.Parse(inputStr.Substring(6, 4));
                if (age >= 18)
                {
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                    MessageBox.Show("你还小，看不了");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
        }

    }
}
