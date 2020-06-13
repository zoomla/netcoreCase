using System;

namespace 字符串string2查找r在字符中出现的位置
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "we are the world";    //创建字符串
            int firstIndex = str.IndexOf("r");    //获取r第一次出现索引的位置
            int secondIndex = str.IndexOf("r", firstIndex + 1);
            int thirdTindex = str.IndexOf("r", secondIndex + 1);
            Console.WriteLine("r字符第一次出现的位置是：" + firstIndex);
            Console.WriteLine("r字符第二次出现的位置是：" + secondIndex);
            Console.WriteLine("r字符第三次出现的位置是：" + thirdTindex);
        }
    }
}
