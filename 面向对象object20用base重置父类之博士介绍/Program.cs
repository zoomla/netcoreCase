using System;

namespace 面向对象object20用base重置父类之博士介绍
{
    class Person
    {
        public string Introduce()
        {
            return "我是xxx";
        }
    }
    class Doctou : Person
    {
        public string Introduce()
        {
            return base.Introduce() + "博士" + "班上的同学";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine(person.Introduce());
            Doctou doctor = new Doctou();
            Console.WriteLine(doctor.Introduce());
            Console.ReadLine();
        }
    }
}
