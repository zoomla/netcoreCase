using System;

namespace _002switch分支语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要查询的录取分数线（比如民办本科、艺术类本科、体育类本科、一本、二本");
            string strNum = Console.ReadLine(); //获取用户输入的数据
            switch (strNum)
            {
                case "民办本科":
                    Console.WriteLine("民办本科录取分数线： 350");
                break;
                case "艺术类本科":
                    Console.WriteLine("艺术类本科录取分数线：290");
                    break;
                case "体育类本科":
                    Console.WriteLine("体育类本科录取分数线：280");
                    break;
            }
            Console.ReadLine();
        }
    }
}
