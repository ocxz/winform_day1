using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_日期选择器
{
    public static class MyUtils
    {

        /// <summary>
        /// 输入1个年份，判断是否是闰年
        /// </summary>
        /// <param name="year">判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsLeapYear(int year)
        {
            // 能被400整除，或者能被4整除，不能被100整除  是闰年，2月多一天
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
            {
                return true;
            }
            return false;
        }

        /// <summary> 
        /// 根据年份和月份返回天数 1、3、5、7、8、10、12是30天，2月是29/28天，其余31天
        /// </summary>
        /// <param name="year">年份</param>
        /// <param name="month">月份</param>
        /// <returns>返回的天数</returns>
        public static int GetDayFromYandM(int year, int month)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 2:
                    int day = IsLeapYear(year) ? 29 : 28; 
                    return day;   // 2月 判断是否是闰年，是返回29天，不是返回28天
                default:
                    return 30;
            }
        }
    }
}
