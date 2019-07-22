using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace _20_picture
{
    public partial class Form1 : Form
    {
        private string[] pictures = System.IO.Directory.GetFiles(@"E:\图片\test\业务\个人相册\img");
        private Random r = new Random();
        private PictureBox[] pbs = new PictureBox[4];

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pb1.Image = Image.FromFile(pictures[0]);
            pb2.Image = Image.FromFile(pictures[0]);
            pb3.Image = Image.FromFile(pictures[0]);
            pb4.Image = Image.FromFile(pictures[0]);
            pbs[0] = pb1;
            pbs[1] = pb2;
            pbs[2] = pb3;
            pbs[3] = pb4;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            int pindex1, pindex2, pindex3, pindex4;
            while (true)
            {
                pindex1 = r.Next(0, pictures.Length);
                pindex2 = r.Next(0, pictures.Length);
                pindex3 = r.Next(0, pictures.Length);
                pindex4 = r.Next(0, pictures.Length);
                if (pindex1 != pindex2 && pindex2 != pindex3 && pindex3 != pindex4)
                {
                    break;
                }
            }
            pb1.Image = Image.FromFile(pictures[pindex1]);
            pb2.Image = Image.FromFile(pictures[pindex2]);
            pb3.Image = Image.FromFile(pictures[pindex3]);
            pb4.Image = Image.FromFile(pictures[pindex4]);
        }
    }
}
