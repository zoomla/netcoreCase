using System;
using System.Text;

namespace 面向对象object27接口interface中美说话
{
    //声明一个接口，用于定义seak方法，而具体的speak功能的实现是在类中进行的
    interface ISelectLanguage
    {
        void Speak(string str);
    }
    //如果跟中国人说话则说汉语
    class C_SpeakChinese : ISelectLanguage
    {
        public void Speak(string str)
        {
            Console.WriteLine("您对中国友人说：" + str);
        }
    }
    //如果跟美国人对话，则说英语
    class C_SpeakEnglish : ISelectLanguage
    {
        public void Speak(string str)
        {
            Console.WriteLine("您对美国友人说：" + str);
        }
    }


    class Program
    {
        //检测是否为汉字
        public static bool CheckChinese (string str)
        {
            bool flag = false;
            UnicodeEncoding a = new UnicodeEncoding();
            byte[] b = a.GetBytes(str);
            for (int i = 0; i < b.Length; i++)
            {
                i++;
                if (b[i] !=0)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            }
            return flag;
        }


        static void Main(string[] args)
        {
            ISelectLanguage iSpeek;
            Console.WriteLine("请输入要说的话：");
            string str = Console.ReadLine();
            if (Program.CheckChinese(str))
            {
                iSpeek = new C_SpeakChinese();
                iSpeek.Speak(str);
            }
            else
            {
                iSpeek = new C_SpeakEnglish();
                iSpeek.Speak(str);
            }
            Console.ReadLine();
        }
    }
}
