using System;

namespace 面向对象object06
{
    class Cellphone
    {
        public Cellphone()
        {
            Console.WriteLine("智能手机的默认语言为英文");
        }
        public Cellphone(string defaultlaguage)
        {
            Console.WriteLine("将智能手机的默认语言设置为" + defaultlaguage);
        }
        static void Main(string[] args)
        {
            Cellphone cellphone1 = new Cellphone();
            Cellphone cellphone2 = new Cellphone("中文");
            Console.ReadLine();
        }
    }
}
