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

namespace _09_简单记事本
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            btnWordWrap.Visible = false;
            btnSave.Visible = false;
            textWords.Visible = false;

            // 取消文本框的自动换行
            textWords.WordWrap = false;
        }

        /// <summary>
        /// 点击登录时，判断用户输入名、密码是否正确
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // 获得用户输入的用户名、密码
            string uName = userName.Text;
            string uPwd = userPwd.Text;

            // 判断用户名或密码是否正确
            if (uName == "admin" && uPwd == "admin")
            {
                // 登录成功 两个登录输入框、两个标签消失、登录重置按钮消失，自动换行、保存按钮、文本输入框显示，焦点在文本输入框
                MessageBox.Show("登录成功");  // 弹出提示框，提示用户登录成功

                // 消失
                userName.Visible = false;
                userPwd.Visible = false;
                nameLabel.Visible = false;
                pwdLabel.Visible = false;
                btnLogin.Visible = false;
                btnReset.Visible = false;

                // 显示
                btnWordWrap.Visible = true;
                btnSave.Visible = true;
                textWords.Visible = true;

                // 文本输入框聚焦
                textWords.Focus();

            }
            else
            {
                // 登录失败  提示用户  清空输入框内容  焦点设在用户名输入框中
                MessageBox.Show("登录失败");

                // 清空输入
                userName.Text = null;
                userPwd.Text = null;

                // 用户输入框获得焦点
                userName.Focus();
            }

        }

        /// <summary>
        /// 重置 用户名输入清空 密码输入清空 用户名输入框获得焦点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {

            userName.Text = null;
            userPwd.Text = null;
            userName.Focus();

        }

        /// <summary>
        /// 点击自动换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnWordWrap_Click(object sender, EventArgs e)
        {
            if ("自动换行".Equals(btnWordWrap.Text))
            {
                // 点按钮时，如果文本时自动换行，则设置文本换行，改变按钮文本为取消自动换行

                textWords.WordWrap = true;  // 设置文本输入框自动换行
                btnWordWrap.Text = "取消自动换行";  // 设置按钮文本为取消自动换行
            }
            else
            {
                textWords.WordWrap = false;   // 设置文本输入框不换行
                btnWordWrap.Text = "自动换行";   // 设置按钮文本为自动换行

            }
        }

        /// <summary>
        /// 点击保存时，将文本框中的内容保存到文本文件中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSave_Click(object sender, EventArgs e)
        {
            // 利用IO流，将文本内容保存至文本文件
            string path = @"C:\Users\sowhat\Desktop\";
            string fileName = "text.txt";

            using (FileStream fsWrite = new FileStream(path + fileName, FileMode.Append, FileAccess.Write))
            {
                // 获得文本输入框的内容，转换为字节码数组
                string text = textWords.Text;

                // 每次写完后的尾部提示
                string timeStr = DateTime.Now.ToLongDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString();
                text += "\n\n**************记录时间为:" + timeStr + "**************\n\n";

                // 转化为字节码文件
                byte[] buffer = Encoding.Default.GetBytes(text);

                // 写入文件中
                fsWrite.Write(buffer, 0, buffer.Length);
            }

            MessageBox.Show("保存成功");
            textWords.Focus();
            textWords.Text = null;
        }
    }
}
