using System;

namespace 面向对象object15曹操败走华容道
{
    public class Person
    {
        string name;
        string actionStr;
        string shoutStr;
        string bbb;
        public Person(string name,string actionStr,string shoutStr,string bbb)
        {
            this.name = name;
            this.actionStr = actionStr;
            this.shoutStr = shoutStr;
            this.bbb = bbb;

        }
        public void action()
        {
            Console.WriteLine(name + actionStr);
        }
        public void shout()
        {
            Console.WriteLine(name + ":" + shoutStr);
        }
        public void shoutb()
        {
            Console.WriteLine(name + ":" + bbb);
        }
        public void escape()
        {
            Console.WriteLine(name + "落荒而逃");
        }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Person caocao = new Person("曹操", "落荒而逃", "哈哈哈","233232");
            Person xuhuang = new Person("徐晃", "上前拦截","莫动我主公！", "233232");
            Person zhanghe = new Person("张郃", "上前拦截", "莫动我主公", "233232");
            Person zhangliao = new Person("张辽", "上前拦截", "莫动我主公", "233232\n");

            Person zhaoyun = new Person("赵云", "拦截去路", "吾乃常山赵子龙，曹贼哪里跑！", "拿出长矛飞奔敌前");
            Person zhangfei = new Person("张飞", "拦截去路", "燕人张飞在此，曹贼哪里跑！", "233232");
            Person guanyu = new Person("关羽", "拦住去路", "长叹一声", "233232\n");

            Console.WriteLine("曹操赤壁失利，败走华容道");
            caocao.shout();
            zhaoyun.action();
            zhaoyun.shout();
            zhaoyun.shoutb();
            xuhuang.action();
            xuhuang.shout();
            zhanghe.action();
            zhanghe.shout();
            caocao.action();

            caocao.shout();
            zhangfei.action();
            zhangfei.shout();
            zhangliao.action();
            zhangliao.shout();
            xuhuang.action();
            xuhuang.shout();
            caocao.action();

            caocao.shout();
            guanyu.action();
            guanyu.shout();
            caocao.action();
            Console.ReadLine();

        }
    }
}
