using System;

namespace 面向对象object19用base重置父类之人类自我介绍
{
    class ren //父类人类
    {
        public string sayMe()
        {
            return "我是张小泉";
        }
    }
    class ren_bosi : ren
    {
        public string ren_boshi_tou="各位领导好";
        public string TradeCode { get; set; }//定义商品编号
        public  string ren_boshi_jiesao()
        {
            TradeCode = "3625522";
            return TradeCode + base.sayMe();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ren_bosi rrrr = new ren_bosi();
            Console.WriteLine(rrrr.ren_boshi_jiesao());
            Console.ReadLine();
        }
    }
}
