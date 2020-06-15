using System;

namespace 面向对象object05根据星期几定义控制台颜色
{
    class UI //定义用户界面类
    {
        static UI() //定义静态构造函数
        {
            DateTime week = DateTime.Now; //记录当前时间
            //判断是否为周六、周日
            if (week.DayOfWeek==DayOfWeek.Saturday||week.DayOfWeek==DayOfWeek.Sunday)
            {
                Console.BackgroundColor = ConsoleColor.Green; //设置颜色为绿色
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Blue; //设置为另一种颜色 -蓝色

            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            UI ui = new UI(); //使用默认构造函数创建UI类的对象
            Console.ReadLine();
        }
    }
}
