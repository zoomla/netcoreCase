using System;

namespace 数组4打印输出杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            //int origWidth;
            //origWidth = Console.WindowWidth;
            int[][] 本案数组 = new int[12][];
            //向数组中记录杨辉三角的值
            for (int i = 0; i < 本案数组.Length; i++)
            {
                本案数组[i] = new int[i + 1];
                for (int j = 0; j < 本案数组[i].Length; j++)
                {
                    if (i <=1 )
                    {
                        本案数组[i][j] = 1;
                        continue;
                    }
                    else
                    {
                        if (j == 0 || j == 本案数组[i].Length - 1)    //如果是行首或行尾
                            本案数组[i][j] = 1;    //将其设置为1
                        else
                            本案数组[i][j] = 本案数组[i - 1][j - 1] + 本案数组[i - 1][j];
                    }
                }
            }
            for (int i = 0; i <= 本案数组.Length-1; i++)  //输出杨辉三角
            {
                //循环控制每行前面打印的空格数
                for (int k = 0; k <= 本案数组.Length - i; k++)
                {
                    Console.Write(" ");
                }
                //循环控制每行打印的数据
                for (int j = 0; j < 本案数组[i].Length; j++)
                {

                    Console.WindowWidth = 100;
                    Console.Write("{0} ", 本案数组[i][j]);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
