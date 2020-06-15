using System;

namespace 面向对象object02输出员工姓名及年龄字段
{

    class Employee //定义员工类
    {
        public string name { get; set; } //定义姓名字段
        public int age { get; set; } //定义员工年龄
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(); //创建员工类的对象
            e.name = "小王"; //为姓名字段赋值
            e.age = 30; //为年龄字段赋值
            //输出员工的姓名及年龄
            Console.WriteLine("姓名：{0}  年龄：{1}", e.name, e.age);
            Console.ReadLine();
        }
    }
}
