using System;
using System.Runtime.CompilerServices;

namespace 数组1输出一年每月天数
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建并初始化一维数组
            int[] day = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine((i + 1) + "月有" + day[i] + "天");   //输出的信息
            }
            Console.ReadLine();
        }
    }
}
