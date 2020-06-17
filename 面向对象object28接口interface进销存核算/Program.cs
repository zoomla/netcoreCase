using System;

namespace 面向对象object28接口interface进销存核算
{
    interface Information //定义接口
    {
        string Code { get; set; } //编号属性
        string Name { get; set; } //名称属性
        void ShowInfo(); //用来输出信息
    }
    public class Sale :Information
    {
        string code = "";
        string name = "";
        public string Code//实现编号号性
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }
        public string Name //实现名称属性
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public Sale(string code,string name)
        {
            Code = code;
            Name = name;
        }
        public void ShowInfo() { }
        public static void ShowInfo(Sale[] sales) //定义ShowInfo方法，用来输出销售的信息
        {
            foreach (Sale s in sales)
            {
                Console.WriteLine("商品编号" + s.code + "商品名称:" + s.Name);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------销售明细--------------");
            //创建sale数组，用来存储1-3月份的和线月销售商品
            Sale[] salesJan = { new Sale("T1001", "笔记本电脑"),new Sale("T0002", "华为荣耀6x"), new Sale("T003", "ipad"), new Sale("T004", "华为荣耀v9"), new Sale("T005", "mac bood电脑") };
            Sale[] salesFeb = { new Sale("T006", "华为荣耀9标配版"), new Sale("T007", "华为荣耀9高配版") };
            Sale[] salesMar = { new Sale("T003,", "ipad"), new Sale("T004", "华为荣耀v9"), new Sale("T008", "一加手机"), new Sale("T009", "充电宝") };
            while (true)
            {
                Console.WriteLine("\n请输出要查询的月份（比如1、2、3等）：");
                try
                {
                    int month = Convert.ToInt32(Console.ReadLine());
                    switch (month)
                    {
                        case 1:
                            Console.WriteLine("1月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan); //调用方法输出销售的商品信息
                            break;
                        case 2:
                            Console.WriteLine("2月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan);                        
                        break;
                        case 3:
                            Console.WriteLine("3月份的商品销售明细如下：");
                            Sale.ShowInfo(salesJan);
                            break;
                        default:
                            Console.WriteLine("该月没有销售数据或者输入的月份有误！");
                            break;
                    }
                }
                catch (Exception ex) //捕获可能现现的异常信息
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }
    }
}
