using System;

namespace _11continue办公卡位计算
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("公司有4*4个卡位，其中第一排第3个和第3排第2个卡位被使用，算出未使用卡位。");
            Console.WriteLine("本公司尚未使用的卡位：");
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if ((i == 1 && j == 3) || (i == 3 && j == 2))
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("第" + i + "排，第" + j + "列");
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
