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

namespace _16_图片控件
{
    public partial class Form1 : Form
    {

        private static Form1 form1;


        // 一个数组，用来获得存放，所有放映的图片url
        private string[] pictures = Directory.GetFiles(@"E:\图片\test\业务\个人相册\img", "*.jpg");

        // 用来存储，当前图片在数组中的索引位置
        private int picturesIndex = 0;

        private Form1()
        {
            InitializeComponent();
        }

        public static Form1 GetForm()
        {
            if (form1 == null)
            {
                form1 = new Form1();
            }
            return form1;
        }

        /// <summary>
        /// 点击播放上一张图片，如果当前图片是第一张，则播放最后一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLast_Click(object sender, EventArgs e)
        {
            // 当前图片索引是否为0，如果为0，上一张图片的索引应该为最后一张，否则减一即可
            picturesIndex = picturesIndex == 0 ? pictures.Length - 1 : picturesIndex-1;

            // 设置当前播放的图片
            pictureBox1.Image = Image.FromFile(pictures[picturesIndex]);
        }

        /// <summary>
        /// 点击播放下一张图片，如果当前图片为最后一张，则播放第一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            // 如果当前图片为最后一张，则图片索引变为0，否则加一即可

            picturesIndex = picturesIndex == pictures.Length - 1 ? 0 : picturesIndex + 1;

            // 播放当前索引所在的图片
            pictureBox1.Image = Image.FromFile(pictures[picturesIndex]);
        }

        /// <summary>
        /// 点击结束放映，程序退出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 计算器，显示当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            string timeNow = DateTime.Now.ToLongDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString();

            timeLabel.Text = timeNow;
        }

        /// <summary>
        /// 窗口初始化时，显示当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string timeNow = DateTime.Now.ToLongDateString().ToString() + "  " + DateTime.Now.ToLongTimeString().ToString();

            timeLabel.Text = timeNow;
        }
    }
}
