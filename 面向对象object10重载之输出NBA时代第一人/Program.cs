using System;

namespace 面向对象object10重载之输出NBA时代第一人
{
    class Program
    {
        public void ShowInfo (int[] intYear)
        {
            for (int i = 0; i < intYear.Length; i++)
            {
                Console.Write(intYear[i] + "\t");
            }

        }
        public void ShowInfo(string[] strName)
        {
            for (int i = 0; i < strName.Length; i++)
            {
                Console.Write(strName[i] + "\t");
            }
        }
        static void Main(string[] args)
        {
            Program pro = new Program();
            pro.ShowInfo(new int[] { 1950, 1960, 1970, 1980, 1990, 2000, 2010 });
            Console.WriteLine();
            pro.ShowInfo(new string[] { "麦肯", "拉塞尔", "贾巴尔", "鹰鸟", "乔丹", "邓肯", "詹姆斯" });
            Console.ReadLine();
        }
    }
}
