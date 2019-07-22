using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22_下拉框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] fruits = { "苹果", "香蕉", "梨", "西瓜" };
            foreach (var item in fruits)
            {
                cb2.Items.Add(item);
            }

            cb3.Items.AddRange(fruits);
        }
    }
}
