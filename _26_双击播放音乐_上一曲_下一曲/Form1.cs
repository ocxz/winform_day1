using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _26_双击播放音乐_上一曲_下一曲
{
    public partial class Form1 : Form
    {
        private List<string> picNamesList = new List<String>();
        private int picIndex = 0;     // 声明一个变量，表示当前图片的索引
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时，给listBox填充数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            // 获得当前文件夹索引jpg文件路径
            string[] picNames = System.IO.Directory.GetFiles(@"E:\图片\test\业务\个人相册\img", "*.jpg");
            for (int i = 0; i < picNames.Length; i++)
            {
                picNamesList.Add(picNames[i]);   // 将路径加到list中

                string picName = System.IO.Path.GetFileName(picNames[i]);   // 获得文件名
                listBox1.Items.Add(picName);  // 将文件名循环添加到listBox中
            }

            pictureBox1.Image = Image.FromFile(picNamesList[0]);
            listBox1.SetSelected(0, true);  // 初始设置第0项为初始项目
        }


        /// <summary>
        /// 双击查看图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1_DoubleClick(object sender, EventArgs e)
        {
            // 设置更新当前所选项索引
            picIndex = listBox1.SelectedIndex;
            string spicName = picNamesList[picIndex];   // 获取当前所选项名

            pictureBox1.Image = Image.FromFile(spicName);   
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            // 如果当前索引为0时，设置为最后一项，否则减一
            picIndex = picIndex == 0 ? picNamesList.Count - 1 : picIndex - 1;

            try
            {
                pictureBox1.Image = Image.FromFile(picNamesList[picIndex]);
            }
            catch (Exception)
            {
                MessageBox.Show("查看失败，回到第一张图片");
                picIndex = 0;
                pictureBox1.Image = Image.FromFile(picNamesList[picIndex]);
            }

            // 设置，当前选项为选中状态
            listBox1.SetSelected(picIndex, true);
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            // 当前为最后一项时，设置为0，否则加一
            picIndex = picIndex == picNamesList.Count - 1 ? 0 : picIndex + 1;
            try
            {
                pictureBox1.Image = Image.FromFile(picNamesList[picIndex]);
            }
            catch
            {
                MessageBox.Show("查看失败，回到第一张图片");
                picIndex = 0;
                pictureBox1.Image = Image.FromFile(picNamesList[picIndex]);
            }

            // 设置，当前选项为选中状态
            listBox1.SelectedIndex = picIndex;
        }
    }
}
