using System;

namespace 面向对象object16继承之模拟进销存系统
{
    class Goods
    {
        public string TradeCode { get; set; }   //定义商品编号
        public string FullName { get; set; }    //定义商品名称
    }
    class JHInfo : Goods      //继承Goosd类

    {
        public string JHID { get; set; }    //定义进货编号
        public void ShowInfo ()  //输出进货信息
        {
            Console.WriteLine("进货编号：{0}\n商品编号：{1}\n商品名称：{2}", JHID, TradeCode, FullName);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            JHInfo jh = new JHInfo();   //创建JHInfo对象
            jh.FullName = "笔记本电脑";
            jh.JHID = "JH0001";
            jh.TradeCode = "T10000";
            jh.ShowInfo();  //输出信息
            Console.ReadLine();
        }
    }
}
