using System;

namespace 字符串string3使用stratswith查找开始字符
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "梦想还是要有的，万一实现了呢！";
            bool result = str.StartsWith("梦想");
            Console.WriteLine("检测\"梦想\"这个词是不是属于\"梦想还是要有的，万一实现了呢\"开头正确输出true,否则false");
            Console.WriteLine(result);
        }
    }
}
