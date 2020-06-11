using System;

namespace _08break跳出循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 1;
            int iSum = 0;
            while ( iNum <= 100)
            {
                iSum += iNum;
                iNum++;
                if (iNum == 50)
                {
                    break;
                }

            }
            Console.WriteLine("1到49累加的结果是：" + iSum);
            Console.ReadLine();
        }
    }
}
