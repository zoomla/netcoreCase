using System;

namespace _06星状项目
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1 ; i < 5; i++)
            {

                for (int 空格 = 1; 空格 <= 5 - i; 空格++)
                {
                    Console.Write(" ");
                }
                for (int 星星 = 1; 星星 <= 2*i-1; 星星++)
                {
                    Console.Write("*");
                }
                Console.ReadLine(); //换行
            }
            Console.ReadLine();
        }
    }
}
