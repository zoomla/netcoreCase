using System;

namespace _07百鸡
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5文钱买一只公鸡，3文钱买一只母鸡，1文钱可以买三只小鸡，百钱可以买几只鸡？");
            int gongj, muj, xiaoj;
            for ( gongj = 0; gongj <=  20; gongj++)
            {
                for (muj = 0; muj <= 33; muj++)
                {
                    for ( xiaoj = 3; xiaoj <= 99; xiaoj+= 3)
                    {

                        if(5* gongj + 3* muj + xiaoj / 3 == 100 ) //百钱
                        {
                            if (gongj + muj + xiaoj ==100) //百鸡
                            {
                                Console.WriteLine("公鸡：" + gongj + " 母鸡：" + muj + " 小鸡:" + xiaoj);

                            }
                        }
                    }

                }
            }
            Console.ReadLine();
        }
    }
}
