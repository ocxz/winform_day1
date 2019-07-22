using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_MDI窗体
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 展示子窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 分别创建子窗体对象
            Form2 form2 = new Form2();
            Form3 form3 = new Form3();
            Form4 form4 = new Form4();

            // 显示窗体
            form2.Show();
            form3.Show();
            form4.Show();

            // 设置子窗体
            form2.MdiParent = this;
            form3.MdiParent = this;
            form4.MdiParent = this;
        }

        private void 横向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 父窗体内容横向排列
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void 纵向排列ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 父窗体内容纵向排列
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
