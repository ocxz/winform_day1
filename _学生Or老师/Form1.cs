using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _学生Or老师
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录时，对身份进行判断
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string name = uName.Text.Trim();
            string pwd = uPwd.Text;

            if (rbStudent.Checked)   // 如果学生被选中
            {
                if ("张三".Equals(name) && "123456".Equals(pwd))
                {
                    MessageBox.Show("学生" + name + "登录成功");
                }
                else
                {
                    MessageBox.Show("学生登录失败", name);
                }


            }
            else if (rbTeacher.Checked)   // 如果老师被选中
            {
                if ("王老五".Equals(name) && "123456".Equals(pwd))
                {
                    MessageBox.Show("老师" + name + "登录成功");
                }
                else
                {
                    MessageBox.Show("老师" + name + "失败");
                }
            }
            else   // 选中的是管理员
            {
                if ("皮卡丘".Equals(name) && "123456".Equals(pwd))
                {
                    MessageBox.Show("管理员{0}登录成功", name);
                }
                else
                {
                    MessageBox.Show("管理员登录失败", name);
                }
            }

            // 最后，清空
            uName.Text = null;
            uPwd.Text = null;

        }

        /// <summary>
        /// 点击取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {

            uName.Text = null;
            uPwd.Text = null;
            rbStudent.Checked = true;

        }
    }
}
