using System;

namespace 面向对象object18用base重载父类之电脑与平板关系
{
    class Computer  //父类：电脑
    {
        public string sayHello()
        {
            return "欢迎使用本电脑";
        }
    }
    class Pad : Computer  //子类：平板电脑
    {
        public new string sayHello()  //子类重写父类方法
        {
            return base.sayHello() + "现在开启平板模式";    //调用父类方法，在结果后添加了字符串
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = new Computer();   //电脑类
            Console.WriteLine(pc.sayHello());
            Pad 大王的pad = new Pad();
            Console.WriteLine(大王的pad.sayHello());
            Console.ReadLine();
        }
    }
}
