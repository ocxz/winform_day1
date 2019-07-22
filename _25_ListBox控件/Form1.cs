using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25_ListBox控件
{
    public partial class Form1 : Form
    {
        private List<string> picPathList = new List<string>();  // 通过泛型集合来存储

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时，给listBox赋值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private string[] picNames = System.IO.Directory.GetFiles(@"E:\图片\test\业务\个人相册\img", "*.jpg");
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < picNames.Length; i++)
            {
                string picName = System.IO.Path.GetFileName(picNames[i]);
                listBox1.Items.Add(picName);

                picPathList.Add(picNames[i]);
            }
        }

        /// <summary>
        /// 点击更换图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1_Click(object sender, EventArgs e)
        {
            string spicName = picPathList[listBox1.SelectedIndex];
            pictureBox1.Image = Image.FromFile(spicName);
        }
    }
}
