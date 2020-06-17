using System;

namespace 面向对象object25抽象类方法abstract进货与销售信息
{
    public abstract class Infomation //定义抽象类
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public abstract void ShowInfo();
    }
    public class JHinfo :Infomation //继承抽象类，定义进货类
    {
        public override void ShowInfo()
        {
            Console.WriteLine("进货信息：\n" + Code + "" + Name);
        }
    }
    public class XSinfo :Infomation //继承抽象类，定义销售类
    {
        public override void ShowInfo()
        {
            Console.WriteLine("\n下面是销售货信息");
            Console.WriteLine("销售进信息：\n" + Code + "" + Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Infomation info = new JHinfo();
            info.Code = "JH00001";
            info.Name = "笔记本电脑";
            info.ShowInfo();
            info = new XSinfo();
            info.Code = "XS0001";
            info.Name = "华为荣耀9";
            info.ShowInfo();
            Console.ReadLine();
        }
    }
}
