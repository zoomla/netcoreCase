using System;

namespace _03While挑战高斯
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNum = 1;  //iNum从1到100递增
            int iSum = 0; //记录每次累加后的结果
            while ( iNum <= 100) //iNum <= 100 是循环条件
            {
                iSum += iNum; //把每次iNum的值累加到上次累加的结果中
                iNum++;     //把每次循环iNum的值加1

            }
            //输出结果
            Console.WindowHeight = 100;
            Console.WindowWidth = 100;
            Console.WriteLine("1到100的累加结果是：" + iSum);
            Console.ReadLine();
        }
    }
}
