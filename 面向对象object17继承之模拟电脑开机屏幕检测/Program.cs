using System;
using System.Net;

namespace 面向对象object17继承之模拟电脑开机屏幕检测
{
    class Computer      //父类：电脑
    {
        public string sceen = "液晶显示屏幕"; //属性：屏幕
        public void Startup()
        {
            //方法：开机
            Console.WriteLine("电脑正在开机，请等待....");
        }
    }

    class Pad:Computer
    {   //子类：平板电脑
        public string battery="500毫安电池";    //平板电脑的属性：电池

        static void Main(string[] args)
        {
            Computer pc = new Computer();   //创建电脑类对象
            Console.WriteLine("发哥你好，当前电脑屏幕是：" + pc.sceen);
            pc.Startup();//电脑对象调用开机方法
            Pad ipad = new Pad();//创建平板电脑对象
            Console.WriteLine("Pad屏幕规格是：" + ipad.sceen);    //平板电脑类对象使用父类属性
            Console.WriteLine("PAD电脑的容量：" + ipad.battery);  //平板电脑类对象使用自己的方法
            ipad.Startup(); //平板电脑对象使用父类的方法
            Console.ReadLine();
        }
    }
}
