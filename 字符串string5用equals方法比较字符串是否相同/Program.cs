using System;

namespace 字符串string5用equals方法比较字符串是否相同
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逐浪CMS登录密码（用户名：逐浪，密码：123456）");
            Console.WriteLine("请输入用户名：");
            string name = Console.ReadLine();  //记录输入的用户名
            Console.WriteLine("请输入登录密码：");
            string password = Console.ReadLine();
            if (name == "逐浪" && password.Equals("123456")) 
            {
                Console.WriteLine("登录成功，欢迎访问逐浪CMS网站系统...");
            }
            else
            {
                Console.WriteLine("错误，请检查输入的用户名和密码！！！");
            }
            Console.ReadLine();
        }
    }
}
