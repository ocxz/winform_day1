using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_部分类
{
    public partial class Person   // 部分类，多个部分类，到时候会组合成一个类
    {
        private string _name = "比比东";
        private int _age = 19;
    }

    public partial class Person
    {
        public void SayHello()
        {
            Console.WriteLine("大家好，我是{0}，我今年{1}岁了",_name,_age);
        }
    }
}
