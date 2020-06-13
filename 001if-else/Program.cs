using System;

namespace study0611
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入你的分数：");
            int score = Convert.ToInt32(Console.ReadLine()); //记录用户的输入
            if (score > 90)
            {
                Console.WriteLine("哥，你太优秀了");
            }
            else if (score < 90 & score>80)
            {
                Console.WriteLine("你也还行，二等");
            }
            else
            {
                Console.WriteLine("再继再励！");
            }
            Console.ReadLine();
        }
    }
}
