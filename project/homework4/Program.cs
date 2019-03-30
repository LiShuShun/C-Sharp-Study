using System;

namespace homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用MySopping管理系统");
            Console.WriteLine("************************************************");
            Console.WriteLine("\t1.客户信息管理\n\t2.购物结算\n\t3.真情回馈\n\t4.注销");
            Console.WriteLine("************************************************");

            int number = 0;
            Console.Write("请选择，输入数字：");
            while (number < 1 || number > 4) //输入数字小于1或者大于4
            {   
                number = int.Parse(Console.ReadLine());
                switch (number)
                {
                    case 1:
                        Console.WriteLine("客户信息");
                        break;
                    case 2:
                        Console.WriteLine("购物");
                        break;
                    case 3:
                        Console.WriteLine("回馈");
                        break;
                    case 4:
                        Console.WriteLine("注销");
                        break;
                    default:
                         Console.Write("输入错误重新输入:");
                        break;
                }
            }
            Console.WriteLine("程序结束");
            Console.ReadLine();
            
        }
    }
}
