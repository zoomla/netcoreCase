using System;

namespace _05九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            int iRow, iColumn;
            for (iRow = 1; iRow < 10; iRow++)
            {
                for (iColumn = 1; iColumn <= iRow; iColumn++)
                {
                    //输出每一行数据
                    Console.Write("{0}*{1}={2} ", iColumn, iRow, iRow * iColumn );
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
