using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _27_打开对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnOpen_Click(object sender, EventArgs e)
        {
            // 创建文件打开对话框对象
            OpenFileDialog ofd = new OpenFileDialog();

            // 设置标题
            ofd.Title = "请选择要打开的文件";

            // 设置打开文件类型
            ofd.Filter = "文本文件|*.txt|图片文件|*.jpg|图片文件|*.png|所有文件|*.*";

            // 设置是否可多选
            ofd.Multiselect = true;

            // 设置默认打开文件夹
            ofd.InitialDirectory = @"E:\图片\test\业务\个人相册\img";

            // 显示对话框
            ofd.ShowDialog();
        }
    }
}
