using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _17_实时输入
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        /// <summary>
        /// 初始化，展示当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            string timeNow = DateTime.Now.ToString();

            showTime.Text = timeNow;
        }

        /// <summary>
        /// 每隔一秒，showTime文本设置为当前时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Timer1_Tick(object sender, EventArgs e)
        {
            showTime.Text = DateTime.Now.ToString();
        }

        /// <summary>
        /// 文本改变时，触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextInput_TextChanged(object sender, EventArgs e)
        {
            showLabel.Text = inputText.Text;
        }

        /// <summary>
        /// 点击按钮，播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        private void BtnPlayMusic_Click(object sender, EventArgs e)
        {
            //soundPlayer.SoundLocation = "";
            //soundPlayer.Play();
        }
    }
}
