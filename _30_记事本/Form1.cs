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
using System.Text;

namespace _30_记事本
{
    public partial class Form1 : Form
    {
        private List<string> fileNameList = new List<string>();
        private string initDirectory = @"C:\Users\sowhat\Desktop";
        private string curFilePath;  // 用来存储当前文件路径
        private string initTitle = "我的记事本                                                                  ";
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 初始化时，panel隐藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Text = initTitle + "新建文件.txt";
        }

        /// <summary>
        /// 点击打开文件时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
            panel1.Visible = false;
            fileNameList.Remove(curFilePath);
            fileNameList.Insert(0, curFilePath);
        }

        /// <summary>
        /// 点击保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(curFilePath))   // 如果当前文件不存在，则保存
            {
                SaveFileOther(textBox1.Text);
            }
            else
            {
                if (panel1.Visible)   // 如果显示记录
                {
                    SaveFile(curFilePath, txRight.Text);
                }
                else
                {
                    SaveFile(curFilePath, textBox1.Text);
                }
            }

            fileNameList.Remove(curFilePath);
            fileNameList.Insert(0, curFilePath);
        }

        /// <summary>
        /// 另存为，文件再存放一个位置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 另存为ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileOther(textBox1.Text);
            OpenFile(curFilePath,textBox1);

            panel1.Visible = false;
            fileNameList.Remove(curFilePath);
            fileNameList.Insert(0, curFilePath);
        }

        /// <summary>
        /// 打开，并保存文件
        /// </summary>
        private void OpenFile()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要打开的文件";
            ofd.Filter = "文本文件|*.txt|所有文件|*.*";
            ofd.InitialDirectory = initDirectory;
            ofd.Multiselect = true;
            ofd.ShowDialog();
            string[] fileNames = ofd.FileNames;
            if (fileNames.Length == 0)
            {
                MessageBox.Show("请选择需要打开的文件");
                return;
            }
            for (int i = 0; i < fileNames.Length; i++)
            {
                fileNameList.Remove(fileNames[i]);
                fileNameList.Add(fileNames[i]);
            }
            OpenFile(fileNames[0],textBox1);
        }

        private void OpenFile(string filePath,TextBox tb)
        {
            using (FileStream fsRead = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[fsRead.Length];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                tb.Text = Encoding.Default.GetString(buffer);
            }
            curFilePath = filePath;
            this.Text = initTitle + Path.GetFileName(curFilePath);
        }

        /// <summary>
        /// 保存已有文件
        /// </summary>
        /// <param name="filePath"></param>
        private void SaveFile(string filePath,string text)
        {
            byte[] buffer = Encoding.Default.GetBytes(text);
            using (FileStream fsWrite = new FileStream(curFilePath, FileMode.Open, FileAccess.Write))
            {
                fsWrite.Write(buffer, 0, buffer.Length);
                MessageBox.Show("文件保存成功");
            }
            this.Text = initTitle + Path.GetFileName(curFilePath);   // 设置标题为当前文件路径
        }

        /// <summary>
        /// 另存为文件 文件不存在时，创建并保存文件
        /// </summary>
        private void SaveFileOther(string text)
        {
            byte[] buffer = Encoding.Default.GetBytes(text);
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "保存文件";
            sfd.InitialDirectory = initDirectory;
            sfd.Filter = "文本文件|*.txt|所有文件|*.*";
            sfd.ShowDialog();

            string sfilePath = sfd.FileName;

            if (sfilePath.Length == 0)
            {
                MessageBox.Show("文件保存失败，请选择保存路径");
                return;
            }

            using (FileStream fsWrite = new FileStream(sfilePath, FileMode.Create, FileAccess.Write))
            {
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            curFilePath = sfilePath;  // 设置当前文件路径

            this.Text = initTitle + Path.GetFileName(curFilePath);   // 设置标题为当前文件路径
            MessageBox.Show("文件保存成功");
        }

        /// <summary>
        /// 点击设置字体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 字体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 创建字体选中对话框
            FontDialog ftd = new FontDialog();
            // 显示字体选择对话框
            ftd.ShowDialog();
            // 设置字体
            textBox1.Font = ftd.Font;
            if (panel1.Visible)
            {
                txRight.Font = ftd.Font;
            }
        }

        /// <summary>
        /// 字体颜色设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 颜色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cod = new ColorDialog();
            cod.ShowDialog();
            textBox1.ForeColor = cod.Color;

            if (panel1.Visible)
            {
                txRight.ForeColor = cod.Color;
            }
        }

        /// <summary>
        /// 点击更改背景色
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 背景色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cod = new ColorDialog();
            cod.ShowDialog();
            textBox1.BackColor = cod.Color;

            if (panel1.Visible)
            {
                txRight.BackColor = cod.Color;
            }
        }

        /// <summary>
        /// 点击取消或者换行
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 取消换行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(取消换行ToolStripMenuItem.Text== "☆取消换行")
            {
                textBox1.WordWrap = false;
                取消换行ToolStripMenuItem.Text = "★换行";
            }
            else
            {
                textBox1.WordWrap = true;
                取消换行ToolStripMenuItem.Text = "☆取消换行";
            }
        }

        /// <summary>
        /// 点击显示记录，显示面板
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 显示记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            lbLeft.Items.Clear();
            for (int i = 0; i < fileNameList.Count; i++)
            {
                lbLeft.Items.Add(Path.GetFileName(fileNameList[i]));
            }

            txRight.Text = textBox1.Text;
            if (lbLeft.Items.Count == 0)   // 如果没有记录
            {
                txRight.Visible = false;
                return;
            }
            txRight.Visible = true;
            lbLeft.SelectedIndex = 0;

            txRight.Font = textBox1.Font;
            txRight.ForeColor = textBox1.ForeColor;
            txRight.BackColor = textBox1.BackColor;
        }

        /// <summary>
        /// 点击隐藏记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 隐藏记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = txRight.Text;
            panel1.Visible = false;
        }

        /// <summary>
        /// 点击隐藏记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = txRight.Text;
            panel1.Visible = false;
        }

        /// <summary>
        /// 双击打开文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbLeft_DoubleClick(object sender, EventArgs e)
        {
            int index = lbLeft.SelectedIndex;
            string sfile = fileNameList[index];
            OpenFile(sfile, txRight);
        }

        private void 清空记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileNameList.Clear();
            lbLeft.Items.Clear();
            txRight.Visible = false;
            MessageBox.Show("清空记录成功");
        }

        /// <summary>
        /// 点击进行新建
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Text = initTitle + "新建文件.txt";
            curFilePath = null;
            panel1.Visible = false;
            textBox1.Text = null;
        }
    }
}
