using System;

namespace 面向对象object13类的静态成员银行利率账户算法
{
    class Program
    {
        //static double rate = 0.0265; //这二者是一样的意义
        public static double rate = 0.0265;

        public void calulateInterest(int principal,int years)
        {
            double var = 1;
            for (int i = 0; i <= years; i++)
            {
                var *= (1 + rate);
            }
            double interests = principal * var - principal;
            Console.WriteLine(years + "年后，存入" + principal + "元所获利率为" + interests.ToString("0.00") + "元RMB。");
        }
        public void changeRate(double newrate)
        {
            rate = newrate / 100;
        }
        static void Main(string[] args)
        {
            int principal;  //存款本金
            int years;      //存款年限
            Console.WriteLine("当年银行死期年利率为：" + (rate * 100) + "%。\n请入存款本金：");
            principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入存款年限：");
            years = Convert.ToInt32(Console.ReadLine());
            Program proOld = new Program();
            proOld.calulateInterest(principal, years);
            Console.WriteLine("利率变了！请输入调整后的存款利率（利率格式：2.65）：");
            double changerate = Convert.ToDouble(Console.ReadLine());
            Program proNem = new Program();
            proNem.changeRate(changerate);
            Console.WriteLine("请输入存款本金：");
            principal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("请输入存款年限：");
            years = Convert.ToInt32(Console.ReadLine());
            proNem.calulateInterest(principal, years);
            Console.ReadLine();
        }
    }
}
