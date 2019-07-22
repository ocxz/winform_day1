using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_写入当前时间
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 获得当前时间  xxxx年xx月xx日   xx:xx:xx

            string timeStr = DateTime.Now.ToLongDateString().ToString() +"  "+ DateTime.Now.ToLongTimeString().ToString();

            timeLabel.Text += timeStr;
        }
    }
}
