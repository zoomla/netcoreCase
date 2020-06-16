using System;

namespace 面向对象object14创建对象输出商品名称
{

    public class cStockInfo  //自定义库存商品类
    {
       public string FullName
        {
            get;
            set;
        }
        public void showGoods() //定义一个无返回值类型的方法
        {
            Console.WriteLine("库存商品名称->");
            Console.WriteLine(FullName); //输出属性值
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            cStockInfo stockInfo = new cStockInfo(); //创建cStockInfo对象
            stockInfo.FullName = "逐浪牌笔记本电脑";    //使用对象调用类成员属性
            stockInfo.showGoods();
            Console.ReadLine();
        }
    }
}
