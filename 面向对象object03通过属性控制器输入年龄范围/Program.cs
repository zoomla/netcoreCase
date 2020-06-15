using System;

namespace 面向对象object03通过属性控制器输入年龄范围
{
    class Program
    {

        private int age;    //定义字段
        public int Age      //定义属性
        {
            get
            {
                return age; //设置get访问器
            }
            set
            {
                if (value >0 && value<70)   //如果数据合理将赋值给字段
                {
                    age = value;
                    Console.WriteLine("你输入的年龄是："+age+"岁\n");
                    Console.WriteLine("你输入的年龄符合脱贫年限0-70岁的要求！");
                }
                else
                {
                    Console.WriteLine("输入数据不合理！");
                }
            }
        }
        static void Main(string[] args)
        {
            Program p = new Program();      //创建Program类的对象
            while (true)
            {
                Console.Write("请输入年龄：");
                p.Age = Convert.ToInt16(Console.ReadLine());    //为年龄属性赋值
            }
        }
    }
}
