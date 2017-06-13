using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace _6._13_zy
{
    
    class Program
    {
        //连接字符串
        public static readonly string strConn = ConfigurationManager.ConnectionStrings["strConn"].ToString();
        //创建连接对象，打开指定的数据源
       public static SqlConnection con = new SqlConnection(strConn);
        static void Main(string[] args)
        {
            while (true)
            {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("A.注册    B增加     C删除     D修改     E退出    ");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("请输入您的选择：");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                //注册
                case 'A':
                    Deam.Register();
                    break;
                //增加
                case 'B':
                    Deam.Add();
                    break;
                //删除
                case 'C':
                    Deam.Delete();
                    break;
                //修改
                case 'D':
                    Deam.Modification();
                    break;
                //退出
                case 'E':
                    return;
                default:
                    Console.WriteLine("输入的选项有误，请重新输入");
                    break;
            }


            Console.ReadKey();

        }
    }
}
}