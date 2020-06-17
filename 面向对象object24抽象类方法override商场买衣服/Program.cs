using System;

namespace 面向对象object24抽象类方法override商场买衣服
{
    public abstract class Market
    {
        public string Name { get; set; }
        public string Goods { get; set; }
        public abstract void shop(); //抽象方法，用来输出信息
    }
    public class WallMarket : Market    //继承抽象类
    {
        public override void shop()
        {
            Console.WriteLine(Name + "购买" + Goods);
        }
    }
    public class TaobaoMarket : Market //继承抽象类
    {
        public override void shop()
        {
            Console.WriteLine(Name + "购买" + Goods);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Market market = new WallMarket();//使用派生类对象创建抽象类对象
            market.Name = "沃尔玛";
            market.Goods = "逐浪牌西服";
            market.shop();
            market = new TaobaoMarket(); //使用派生类对象创建抽象类对象
            market.Name = "淘宝";
            market.Goods = "字体网线上淘宝特价商品";
            market.shop();
            Console.ReadLine();
        }
    }
}
