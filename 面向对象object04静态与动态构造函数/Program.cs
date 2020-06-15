using System;

namespace 面向对象object04静态与动态构造函数
{
    class Program
    {
        static Program()    //静态构造函数
        {
            Console.WriteLine("static");
        }
        private Program()   //实例构造函数
        {
            Console.WriteLine("实例构造函数");
        }
        static void Main(string[] args)
        {
            Program p1 = new Program(); //创建类的对象p1
            Program p2 = new Program(); //创建类的对象p2
            Program p3 = new Program(); //创建类的对象p3
            Console.ReadLine();
        }
    }
}
