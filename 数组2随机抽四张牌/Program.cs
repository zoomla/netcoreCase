using System;

namespace 数组2随机抽四张牌
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] pai = new int[52]; //一幅牌52张，随机选择四张，用0到51表示
            for (int i = 0; i < pai.Length; i++)
            {
                pai[i] = i; //建立一个数组，并进行赋值
            }
            string[] colors = { "方片", "红桃", "黑桃", "梅花" }; ///四种花色
            string[] cards ={"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            //随机打乱牌
            for (int i = 0; i < pai.Length; i++)
            {
                int randoom = new Random().Next(0, pai.Length);
                int temp = pai[i];
                pai[i] = pai[randoom];
                pai[randoom] = temp;

            }
            for (int i = 0; i < 4; i++)
            {
                int num = pai[i] / 13;
                int number = pai[i] % 13; //得到数字
                Console.WriteLine("第"+(i+1)+"张牌：" + colors[num]+"   " + cards[number]); //输出花色和大小

            }
        Console.ReadLine();
        }
    }
}
