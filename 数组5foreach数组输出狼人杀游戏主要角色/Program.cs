using System;

namespace 数组5foreach数组输出狼人杀游戏主要角色
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("狼人杀游戏主要身份：");    //提示消息
            //定义数组，存储狼人杀游戏主要角色
            string[] roles = { "狼人", "预言家", "村民", "女巫", "村长", "丘比特", "猎人", "守卫" };
            foreach (string item in roles)
            {
                Console.WriteLine(item + "");   //输出遍历到元素
            }
            Console.ReadLine();
        }
    }
}
