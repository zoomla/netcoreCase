using System;

namespace 数组6获取二维数组的列数
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[3][];
            arr[0] = new int[5];
            arr[1] = new int[3];
            arr[2] = new int[4];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j]);
                }
                Console.WriteLine();    //换行输出
            }
            Console.ReadLine();
        }
    }
}
