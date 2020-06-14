using System;

namespace 字符串string4比较之馒头与馍馍是否同一物
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "馒头";
            string str2 = "馍馍";
            if ( str1 != str2)
            {
                Console.WriteLine("在中国北方，馒头和馍馍是同一种东西，只是叫法不同。");
            }
            else
            {
                Console.WriteLine("馒头和馍馍不一样！！！！");
            }
            Console.ReadLine();
        }
    }
}
