using System;

namespace _04for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 1, Num2 = 1, temp;
            for (int i = 2; i < 30; i++)
            {
                Num1 += Num2;
                //交换Num1 和 Num2的值 
                temp = Num1;
                Num1 = Num2;
                Num2 = temp;
            }
            Console.WriteLine("第30个数为：" + Num2);
            Console.ReadLine();
        }
    }
}
