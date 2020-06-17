using System;

namespace 面向对象object21虚方法virtual交通工具衍生火车和汽车不同的形态
{
    class Vehicle
    {
        string name;    //定义字段
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public virtual void Move() //定义方法输出交通工具的形态
        {
            Console.WriteLine("{0}都可以移动", name);
        }

    }
    class Train : Vehicle
    {
        public override void Move() //重写交通工具的形态为火车
        {
            Console.WriteLine("{0}在铁轨上行驶", Name);
        }
    }
    class Cart: Vehicle
    {
        public override void Move() //重写交易工具形态为汽车
        {
            Console.WriteLine("{0}在公路上行驶", Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();    //创建vehicle类的实例
            Train train = new Train();          //创建Train类的实例
            Cart cart = new Cart();             //创建cart实例
            //使用基类和派生类对象创建Vehicle类型数组
            Vehicle[] vehicles = { vehicle, train, cart };
            vehicle.Name = "交通工具";              //设置交通工具的名字
            train.Name = "火车";
            cart.Name = "汽车";
            vehicles[0].Move();
            vehicles[1].Move();
            vehicles[2].Move();
            Console.ReadLine();
        }
    }
}
