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

namespace _31_播放器
{
    public partial class Form1 : Form
    {
        // 用来存储音乐列表
        private List<string> musicList = new List<string>();
        private string curMusic;   // 表示当前播放的音乐
        public Form1()
        {
            InitializeComponent();
            listBoxMusic.SelectionMode = SelectionMode.MultiExtended;
            curMusicName.Text = curMusic;

        }

        /// <summary>
        /// 点击添加至列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 添加至列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP4格式|*.mp4|WAV格式|*.wav|全部格式|*.*";
            ofd.Title = "请选择要添加的视频";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"E:\java300集\03";
            ofd.ShowDialog();
            string[] musics = ofd.FileNames;   // 获取选择文件名
            if (musics.Length == 0)   // 如果未选择
            {
                MessageBox.Show("请选择要添加的视频");
                return;
            }

            for (int i = 0; i < musics.Length; i++)     // 循环
            {
                if (!musicList.Contains(musics[i]))   // 如果列表没有，则添加
                {
                    musicList.Insert(0, musics[i]);
                }
            }

            HanderMusicList();  // 将music集合中的数据映射到listBox中1
            MessageBox.Show("添加成功");
        }
        /// <summary>
        /// 点击删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 从列表删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musicList.Count == 0)
            {
                MessageBox.Show("当前没有视频要移除");
                return;
            }
            else if (listBoxMusic.SelectedItems.Count == 0)
            {
                MessageBox.Show("请选择需要移除的视频");
                return;
            }
            else
            {
                for (int i = 0; i < listBoxMusic.SelectedItems.Count; i++)
                {
                    try
                    {
                        if (curMusic == musicList[i] && musicPlayer.playState.ToString() == "wmppsPlaying")
                        {
                            MessageBox.Show("当前文件正在使用，移除失败");
                            continue;
                        }
                        musicList.RemoveAt(listBoxMusic.SelectedIndex);
                    }
                    catch
                    {
                        MessageBox.Show("移除失败");
                    }

                }
            }

            HanderMusicList();   // 将music集合的内容映射到listBox中
            MessageBox.Show("移除成功");
        }

        /// <summary>
        /// 选中 判断选中的是否为当前播放 如是：暂停，如否则播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // 如果 直接显示播放功能
                if (curMusic != musicList[listBoxMusic.SelectedIndex])
                {
                    播放ToolStripMenuItem.Text = "播放";
                }
                else
                {
                    if (musicPlayer.playState.ToString() == "wmppsPlaying")
                    {
                        播放ToolStripMenuItem.Text = "暂停";
                    }
                    else
                    {
                        播放ToolStripMenuItem.Text = "继续";
                    }
                }
            }
            catch
            {

            }
        }

        /// <summary>
        /// 处理，视频列表是否为空
        /// </summary>
        private void HanderMusicList()
        {
            // 如果 视频列表暂无视频
            if (musicList.Count == 0)
            {
                lbNoMusic.Visible = true;
                listBoxMusic.Items.Clear();
                listBoxMusic.BackColor = SystemColors.ActiveBorder;
            }
            else
            {
                listBoxMusic.Items.Clear();
                listBoxMusic.BackColor = SystemColors.Desktop;
                lbNoMusic.Visible = false;
                for (int i = 0; i < musicList.Count; i++)
                {
                    listBoxMusic.Items.Add(Path.GetFileName(musicList[i]));
                }
            }
        }

        private void RemoveMusic()
        {
            listBoxMusic.Items.Clear();
            musicList.Clear();
            // 如果删除时，当前视频正在播放，则不删除这个
            if (musicPlayer.playState.ToString() == "wmppsPlaying")
            {
                listBoxMusic.Items.Add(curMusic);
                musicList.Add(curMusic);
            }
            else
            {
                curMusic = null;
            }
        }

        /// <summary>
        /// 清空列表
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 清空列表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (musicList.Count == 0)
            {
                MessageBox.Show("当前列表再无内容需移除");
                listBoxMusic.Items.Clear();
                return;
            }
            RemoveMusic();
            HanderMusicList();
            MessageBox.Show("清空列表成功");
            if (curMusic != null)
            {
                listBoxMusic.SelectedItem = Path.GetFileName(curMusic);
            }
        }

        /// <summary>
        /// 在窗口加载时，取消播放器自动播放功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            musicPlayer.settings.autoStart = false;
        }


        private void MusicPlay(string musicUrl)
        {
            if (!string.IsNullOrEmpty(musicUrl))
            {
                //清除listBox中的多选
                listBoxMusic.SelectedItems.Clear();
                listBoxMusic.SelectedItem = Path.GetFileName(musicUrl);

                musicPlayer.URL = musicUrl;
                musicPlayer.Ctlcontrols.play();   // 调用方法，播放视频
                curMusicName.Text = Path.GetFileName(musicUrl);
            }
            else
            {
                MessageBox.Show("当前暂无视频播放");
            }
        }

        /// <summary>
        /// 双击播放视频
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListBoxMusic_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                // 当前双击视频不为已播放视频，则开始播放 
                if (curMusic != musicList[listBoxMusic.SelectedIndex])
                {
                    curMusic = musicList[listBoxMusic.SelectedIndex];
                    MusicPlay(curMusic);
                }
                else   // 否则判断当前视频是否处于播放状态，是暂停，否播放
                {
                    if (musicPlayer.playState.ToString() == "wmppsPlaying")   // 当前处于播放状态
                    {
                        musicPlayer.Ctlcontrols.pause();
                    }
                    else if (musicPlayer.playState.ToString() == "wmppsPaused")
                    {
                        musicPlayer.Ctlcontrols.play();
                    }
                }


            }
            catch (Exception)
            {
                MessageBox.Show("播放失败");
                curMusic = null;
            }
        }

        /// <summary>
        /// 单击点击播放
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 播放ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                switch (播放ToolStripMenuItem.Text)
                {
                    case "播放":
                        curMusic = musicList[listBoxMusic.SelectedIndex];
                        播放ToolStripMenuItem.Text = "暂停";
                        MusicPlay(curMusic);
                        break;
                    case "暂停":
                        musicPlayer.Ctlcontrols.pause();
                        播放ToolStripMenuItem.Text = "继续";
                        break;
                    case "继续":
                        musicPlayer.Ctlcontrols.play();
                        播放ToolStripMenuItem.Text = "暂停";
                        break;
                }

            }
            catch
            {
                MessageBox.Show("播放失败");
                curMusic = null;
            }
        }
    }
}
