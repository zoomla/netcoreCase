using System;

namespace _09地铁报道
{
    class Program
    {
        static void Main(string[] args)
        {
            int zhan = 18;
            Console.WriteLine("欢迎乘坐地铁一号线，本次列车即将从始发站出发===>");
            for (int i = 1; i <= zhan; i++)
            {
                if (i == 4)
                {
                    Console.WriteLine("列车即将抵达本次旅行的第" + i + "站，请做好下车的准备。");
                    break;
                }

                else
                {
                    Console.WriteLine("列车即将抵达本次旅行的第" + i + "站。");

                }
            }

            Console.ReadLine();
        }
    }
}
