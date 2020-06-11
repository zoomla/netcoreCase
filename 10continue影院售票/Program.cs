using System;
using System.Globalization;

namespace _10continue影院售票
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("本剧院VIP厅可售座位信息：");
            for (int i = 2; i <= 4; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (j == 1 || j == 10)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("第" + i + "排,第" + j + "列可售");
                    }

                }
                Console.ReadLine();

            }
        }
    }
}
