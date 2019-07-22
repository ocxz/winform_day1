using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_窗体抖动
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击按钮，窗体发生抖动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_Click(object sender, EventArgs e)
        {
            Point oldPoint = this.Location;   // 窗体原位置
            Point newPoint = new Point(oldPoint.X+10, oldPoint.Y+10);   // 窗体抖动后的位置
            for (int i = 0; i < 500; i++)   // 连续变化500次
            {
                this.Location = newPoint;   // 移动窗口
                this.Location = oldPoint;   // 还原位置
            }

        }
    }
}
