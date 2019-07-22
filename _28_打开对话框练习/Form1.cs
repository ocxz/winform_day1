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

namespace _28_打开对话框练习
{
    public partial class Form1 : Form
    {
        private string initpicPath = @"E:\图片\test\业务\个人相册\img";
        private List<string> picNamesList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化时，多项listBox不可见，pictureBox显示第一张图片 label为第一张图片名  初始化并填充picName集合
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Directory.GetFiles(initpicPath)[0]);    // pictureBox显示第一张图片
            listBox1.Visible = false;   // 多项listBox不可见
            label1.Text = Path.GetFileName(Directory.GetFiles(initpicPath)[0]);   // label为第一张图片名

        }

        /// <summary>
        /// 点击单项单项打开时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 单项打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 多项打开listBox 隐藏
            listBox1.Visible = false;

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择你要打开的文件";
            ofd.Filter = "图片文件|*.jpg";
            ofd.InitialDirectory = initpicPath;
            ofd.Multiselect = false;
            ofd.ShowDialog();

            // 获取文件打开的文件名
            string fileName = ofd.FileName;
            pictureBox1.Image = Image.FromFile(fileName);
            label1.Text = Path.GetFileName(fileName);
        }

        /// <summary>
        /// 点击多项打开时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 多项打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 清空多项listBox中的数据
            listBox1.Items.Clear();
            picNamesList.Clear();

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的多项文件";
            ofd.Filter = "图片文件|*.jpg";
            ofd.InitialDirectory = initpicPath;
            ofd.Multiselect = true;
            ofd.ShowDialog();

            // 获取打开多个文件的文件名
            string[] fileNames = ofd.FileNames;
            for (int i = 0; i < fileNames.Length; i++)
            {
                listBox1.Items.Add(Path.GetFileName(fileNames[i]));
                picNamesList.Add(fileNames[i]);
            }
            pictureBox1.Image = Image.FromFile(fileNames[0]);
            label1.Text = Path.GetFileName(fileNames[0]);
            listBox1.Visible = true;
        }

        /// <summary>
        /// 当选择项选中时，展示图片
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(picNamesList[listBox1.SelectedIndex]);
            label1.Text = Path.GetFileName(picNamesList[listBox1.SelectedIndex]);
        }
    }
}
