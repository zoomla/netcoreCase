using System;

namespace 面向对象object01计算圆的面积
{
    class Program
    {
        static double r;
        const double PI = 3.1415926;    //定义一个变量，用来存储圆半径
        static void Main(string[] args)
        {
            Console.Write("请输入圆的半径：");
            Program.r = Convert.ToDouble(Console.ReadLine());   //输入圆半径
            Console.WriteLine("圆的面积为：" + PI * Math.Pow(r, 2));    //计算圆面积
            Console.ReadLine();
        }
    }
}
