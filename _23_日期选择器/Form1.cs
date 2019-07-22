using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _23_日期选择器
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 窗口加载时，加载年份下拉框数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year; i >= 1949; i--)
            {
                cobYear.Items.Add(i + "年");
            }
        }

        /// <summary>
        /// 当选择年份后，加载月份下拉框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CobYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 清理月份下拉框已有的数据
            cobMonth.Items.Clear();

            for (int i = 1; i < 13; i++)
            {
                if (i < 10)
                {
                    cobMonth.Items.Add("0" + i + "月");
                }
                else
                {
                    cobMonth.Items.Add(i + "月");
                }

            }
        }

        /// <summary>
        /// 选择月份后，加载日期下拉框，跟你年份和月份 确定天数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CobMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            cobDay.Items.Clear();

            string yearStr = (string)cobYear.SelectedItem;
            string monthStr = (string)cobMonth.SelectedItem;

            int year = int.Parse(yearStr.Split(new char[] { '年' }, StringSplitOptions.RemoveEmptyEntries)[0]);
            int month = int.Parse(monthStr.Split(new char[] { '月' }, StringSplitOptions.RemoveEmptyEntries)[0]);

            for (int i = 1; i <= MyUtils.GetDayFromYandM(year, month); i++)
            {
                if (i < 10)
                {
                    cobDay.Items.Add("0" + i + "日");
                }
                else
                {
                    cobDay.Items.Add(i + "日");
                }
            }
        }
    }
}
