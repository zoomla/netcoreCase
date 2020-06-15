using System;

namespace 面向对象object08银行帐户交易管理
{
    class CBank
    {
        DateTime[] Date = new DateTime[100]; //操作日期
        double[] Money = new double[100]; //存取金额
        double[] Rest = new double[100]; //余额
        double balance; //每一次交易后的余额
        int top; //访问数组变量
        internal void Bankin(DateTime date,double money)
        {
            Date[top] = date; //将日期保存到日期数组中
            balance += money; //当前金额
            Money[top] = money; //存款金额
            Rest[top] = balance; //余额
            top++;
        }
        internal void Bankout (DateTime date,double money)
        {
            Date[top] = date;//将日期保存到日期数组中
            balance -= money; //当前余额
            Money[top] = -money; //取款金额
            Rest[top] = balance; //余额
            top++;
        }
    internal void Display()
        {
            int i = 0;
            Console.WriteLine("日期***********存入***********支出***********余额\n");
            for ( i = 0; i < top; i++)
            {
                Console.Write(Date[i].ToString("yyyy-MM-dd"));
                if (Money[i]>0)
                {
                    Console.Write("------" + Money[i] + "-------------------");
                }
                else
                {
                    Console.Write("----------------" + -Money[i] + "------------");
                }
                Console.Write(Rest[i]);
                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            CBank account = new CBank();//创建银行帐户
            //CBank fff = new fff();
            account.Bankin(new DateTime(2017, 05, 06), 2000); //存入
            account.Bankin(new DateTime(2017, 05, 08), 3000);
            account.Bankin(new DateTime(2017, 06, 01), 5000);
            account.Bankin(new DateTime(2017, 06, 11), 1000);

            account.Bankout(new DateTime(2018, 2, 3), 900); //支出
            account.Bankout(new DateTime(2018, 2, 13), 1900); //支出
            
            account.Display();
            Console.ReadLine();
        }
    }
}
