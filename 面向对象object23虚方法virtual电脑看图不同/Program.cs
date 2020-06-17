using System;
using System.Net;

namespace 面向对象object23虚方法virtual电脑看图不同
{
    class Computer //父类：电脑
    {
        public virtual void ShowPicture()
        {
            //方法：展示图片
            Console.WriteLine("鼠标点击");
        }
    }
    class pad : Computer //子类：平板电脑pad
    {
        public override void ShowPicture()  //重写父类中展示图片的方法
        {
            Console.WriteLine("手指点击触摸屏");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Computer pc = new Computer();   //创建电脑对象
            Console.Write("PC打开图片：");
            pc.ShowPicture();               //电脑类对象调用展示图片的方法
            pad 平板电脑对象 = new pad();     //创建平板电脑类对象
            Console.Write("Ipad打开图片：");
            平板电脑对象.ShowPicture();
            Console.ReadLine();
               
        }
    }
}
