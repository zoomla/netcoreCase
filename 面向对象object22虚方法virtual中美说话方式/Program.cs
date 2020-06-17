using System;

namespace 面向对象object22虚方法virtual中美说话方式
{
    class People //定义基类
    {
        public virtual void Say(string name) //定义一个虚方法，用来表示人的说话行为
        {
            Console.WriteLine(name); //输出人的名字
        }
             
    }
    class Chinese : People //定义派生类，继承于People类
    {
        public override void Say(string name)
        {
            base.Say(name+"说汉语");
        }
    }
    class American : People //定义派生类，继承于People类
    {
        public override void Say(string name)
        {
            base.Say(name+"说英语!"); ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入的姓名：");
            string strNmae = Console.ReadLine();//记录用户输入的名字
            People[] people = new People[2]; //声明People类型数组
            people[0] = new Chinese();
            people[1] = new American();
            for (int i = 0; i < people.Length; i++) //遍历赋值后的数组
            {
                people[i].Say(strNmae);//根据数组元素调用相应派生类中的重写方法
            }
            Console.ReadLine();
        }
    }
}
