using System;

namespace 面向对象object11类的静态成员计算两个数的和
{
    class Program
    {
        public static int Add(int x,int y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            //类名调用静态方法
            Console.WriteLine("{0}+{1}={2}", 23, 24, Program.Add(23, 34));
            Console.ReadLine();
        }
    }
}
