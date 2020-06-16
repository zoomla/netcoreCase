using System;

namespace 面向对象object12类的静态成员往池中注水
{
    class Program
    {
        public static int water = 0;
        void outlet()   //放水，一次放出2个单位
        {
            if (water >= 2)
            {
                water = water - 2;
            }
            else
            {
                water = 0;
            }
        }
        void inlet()    //放水，一次注入3个单位
        {
            water = water + 3;
        }
        static void Main(string[] args)
        {
            Program outwater = new Program();
            Program inwater = new Program();
            Console.WriteLine("水池水量：" + Program.water);
            Console.WriteLine("水池注入两次。");
            inwater.inlet();
            inwater.inlet();
            Console.WriteLine("水池的水量：" + Program.water);
            Console.WriteLine("\n水池中放水一次。");
            outwater.outlet();
            Console.WriteLine("水池中的水量" + Program.water);
            Console.ReadLine();
        }
    }
}
