using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace _29_保存对话框
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 点击保存文件按钮，弹出文件保存对话框 处理未选中文件异常
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 创建保存文件对话框
            SaveFileDialog sfd = new SaveFileDialog();
            // 设置标题
            sfd.Title = "请选择要保存的文件";
            //设置默认保存路径
            sfd.InitialDirectory = @"C:\Users\sowhat\Desktop";
            // 设置保存格式
            sfd.Filter = "文本文件|*.txt";

            // 打开文件保存对话框
            sfd.ShowDialog();

            // 获得文件保存全路径
            string filePath = sfd.FileName;

            // 处理文件未保存，文件名未空的异常
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("请选择要保存的文件");
                return;  // 结束本次点击事件
            }

            string text = textBox1.Text.Trim();  // 获得文本框文本
            byte[] buffer = System.Text.Encoding.Default.GetBytes(text);  // 转换为字节数组

            using(FileStream fsWrite = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                fsWrite.Write(buffer, 0, buffer.Length);
            }

            MessageBox.Show("保存成功");
            textBox1.Text = null;
            textBox1.Focus();

        }
    }
}
