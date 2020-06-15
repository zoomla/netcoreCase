using System;
using System.Net.NetworkInformation;

namespace 面向对象object09方重置之加法的同运算形式
{
    class Program
    {
        //定义方法add，返回值为int类型，有两个int类型参数
        public static int add( int x, int y )
        {
            return x + y;
        }
        public double add(int x,double y)       //重载方法add，它与第一个的参数类型不同
        {
            return x + y;
        }
        public int add(int x,int y ,int z)      //重载方法add，它与第一个的参数个数不同
        { 
            return x + y + z;
        }
        static void Main(string[] args)
        {
            Program program = new Program();        //创建类对象
            int x = 3;
            int y = 5;
            int z = 7;
            double y2 = 5.5;
            //根据传入的参数类型及参数个人数不同，调用不同的add重载方法
            Console.WriteLine("第一种重载形式：" + x + "+" + y + "=" + program.add(x, y));
            Console.WriteLine("第二种重载形式：" + x + "+" + y2 + "=" + program.add(x, y2));
            Console.WriteLine("第三种重载形式：" + x + "+" + y + "+" +z + "=" + program.add(x, y,z));
            Console.ReadLine();
        }
    }
}
