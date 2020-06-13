using Microsoft.VisualBasic.CompilerServices;
using System;

namespace 字符串string1获取指定字符位置
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "逐浪软件是中国优秀的CMS厂商";
            char chr = str[5];  //将字符串str中索引位置为5的字符串赋值给chr
            Console.WriteLine("逐浪软件是中国优秀的CMS厂商");
            Console.WriteLine("字符串中索引值5的字符是：" + chr); //输出chr
            int size = str.Length;
            Console.WriteLine("其长度共有：" + size + "位");
            //char[] charArray = { ’时','间','就','是','金','钱'};
            //string d = new string(charArray, 4, 2);
            //Console.WriteLine("提取4和2结果是：" + d); 
        }
    }
}
