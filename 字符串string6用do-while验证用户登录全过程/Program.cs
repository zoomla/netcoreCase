using System;

namespace 字符串string6用do_while验证用户登录全过程
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = null; // 创建用户变量，初始值为null
            string password = null; //创建密码变量，初始值为null
            string email = null;
            string phone = null;
            string address = null;
            Console.WriteLine("欢迎来到逐浪CMS dotNET培训网，请新用户注册帐号！\n");

            bool registerNotSuccess = true; //判断用户注册是否成功
            do
            {
                bool nameFlag = true; //验证用户名
                do
                {
                    Console.Write("请输入用户名：");
                    userName = Console.ReadLine(); //记录用户名
                    if ("".Equals(userName)) //判断用户名是否为空
                    {
                        Console.WriteLine("用户名不能为空，请重新输入！");
                    }
                    else
                    {
                        nameFlag = false;
                    }

                } while (nameFlag);

                bool pwdFlag = true;    //验证害惨 
                do
                {
                    Console.Write("请输入用户密码：");
                    string pwdTmp1 = Console.ReadLine();    //记录首次输入密码
                    Console.Write("请再次输入密码：");
                    string pwdTmp2 = Console.ReadLine();    //记录第二次输入密码
                    if (pwdTmp1.Equals(pwdTmp2)) //判断二次密码是否一致录入
                    {
                        pwdFlag = false;
                        password = pwdTmp1;

                    }
                    else
                    {
                        Console.WriteLine("对不起，你的两次密码输入不一致，请重新输入");
                    }
                } while (pwdFlag);

                Console.Write("请输入邮箱地址：");
                email = Console.ReadLine(); //记录Email

                bool phoneFlag = true;  //验证电话号码
                do
                {
                    Console.Write("请输入电话号码:");
                    phone = Console.ReadLine(); //记录电话号码
                    if (phone.Length != 11)//判断长度是否为11位
                    {
                        Console.WriteLine("输入的电话号码位数不对，至少应为11位，请重新输入！");

                    }
                    else
                    {
                        phoneFlag = false;
                    }
                } while (phoneFlag);

                Console.WriteLine("请输入住地址（可选）：");
                address = Console.ReadLine(); //记录地址

                bool notSure = true; //核对用户注册信息
                do
                {
                    Console.WriteLine("\n****请您核对填写的注册信息*****");
                    Console.WriteLine("账号：" + userName);
                    Console.WriteLine("邮箱：" + email);
                    Console.WriteLine("电话：" + phone.Substring(0, 3) + "****" + phone.Substring(7) + "（中间四位加密）");//电话号中间4位用*替代
                    Console.WriteLine("住址：" + address);
                    Console.Write("确认上述信息请输入Y，重新注册请输入N：");
                    string answer = Console.ReadLine(); //确认信息是否正确
                    if (answer.ToUpper().Equals("Y")) //如果输入Y，则表示正确
                    {
                        registerNotSuccess = false;
                        notSure = false;

                    }
                    else if(answer.ToUpper().Equals("N")) //如果输入N，表示错误
                    {
                        registerNotSuccess = true;
                        notSure = false;
                    }
                    else
                    {
                        Console.WriteLine("您的输入有误，请重新输入");
                    }


                } while (notSure);

            } while (registerNotSuccess);

            Console.WriteLine("\n欢迎来到逐浪CMS dotNET培训网，请登录！");

            bool loginFlag = true; //判断是否登录成功
            do
            {
                Console.Write("请输入账号：");
                string inputName = Console.ReadLine(); //记录用户名
                Console.Write("请输入密码：");
                string inputPwd = Console.ReadLine(); //记录密码
                if (null != userName && null != password)//判断用户名和密码是否正确
                {
                    if (userName == inputName && password == inputPwd)
                    {
                        Console.WriteLine("欢迎登录," + userName); //显示登录用户信息
                        Console.WriteLine("你家地址是：" + address);
                        Console.WriteLine("我们这里永久为你保存家庭住址和档案服务");
                        loginFlag = false;

                    }

                    else
                    {
                        Console.WriteLine("您输入的账号密码有误，请重新输入！");
                    }
                }
            } while (loginFlag);
            Console.ReadLine();
        }
    }
}
