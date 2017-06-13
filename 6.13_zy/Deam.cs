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
    class Deam
    {

        /// <summary>
        /// 添加方法
        /// </summary>
        public static void Register()
        {

            try
            {
                Console.WriteLine("请输入用户名");
                string username = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                string pasa = Console.ReadLine();
                Console.WriteLine("请输入用户等级：");
                int jd = Convert.ToInt32(Console.ReadLine());

                if (!string.IsNullOrEmpty(username))
                {
                    //向数据库中添加数据
                    string stradd = string.Format("INSERT INTO dbo.Users( LoginId, LoginPwd, UserLevel )VALUES('{0}','{1}',{2})", username, pasa, jd);
                    //创建一个命令对象
                    SqlCommand cmd = new SqlCommand(stradd, Program.con);
                    //打开连接
                    Program.con.Open();
                    //返回受影响的行数
                    int count = cmd.ExecuteNonQuery();
                    Console.WriteLine("注册成功，插入{0}条记录", count);
                }
                else
                {
                    Console.WriteLine("用户名不能为空！");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //关闭连接
                Program.con.Close();
            }

        }

        /// <summary>
        /// 添加
        /// </summary>
        public static void Add() {
            try
            {
                Console.WriteLine("请输入姓名");
                string name = Console.ReadLine();
                Console.WriteLine("请输入性别（0表示女，1表示男）：");
                int sex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入年龄：");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入邮箱地址：");
                string email = Console.ReadLine();

                if (!string.IsNullOrEmpty(name))
                {
                    //向数据库中添加数据
                    string stradd = string.Format("INSERT INTO dbo.UserInfo(UserName , UserSex , UserAge ,UserEmail)VALUES('{0}',{1},{2},'{3}')",name,sex,age,email);
                    //创建一个命令对象
                    SqlCommand cmd = new SqlCommand(stradd, Program.con);
                    //打开连接
                    Program.con.Open();
                    //返回受影响的行数
                    int count = cmd.ExecuteNonQuery();
                    Console.WriteLine("注册成功，插入{0}条记录", count);
                }
                else
                {
                    Console.WriteLine("用户名不能为空！");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //关闭连接
                Program.con.Close();
            }
        }


        /// <summary>
        /// 删除
        /// </summary>
        public static void Delete() {
            try { 

            Console.WriteLine("请输入要删除的ID：");
             int id = Convert.ToInt32(Console.ReadLine());
            if (id!=0)
            {
                //向数据库中删除数据
                string stradd = string.Format("DELETE dbo.UserInfo WHERE UserId={0}",id);
                //创建一个命令对象
                SqlCommand cmd = new SqlCommand(stradd, Program.con);
                //打开连接
                Program.con.Open();
                //返回受影响的行数
                int count = cmd.ExecuteNonQuery();
                Console.WriteLine("删除成功，{0}条记录", count);
            }
            else
            {
                Console.WriteLine("请输入删除人的id！");
            }
        }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally
            {
                //关闭连接
                Program.con.Close();
            }
        }

        /// <summary>
        /// 修改
        /// </summary>
        public static void Modification() {
            try
            {
                Console.WriteLine("请输入要修改记录的id");
                int id =Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("请输入姓名");
                string name = Console.ReadLine();
                Console.WriteLine("请输入性别（0表示女，1表示男）：");
                int sex = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入年龄：");
                int age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入邮箱地址：");
                string email = Console.ReadLine();
                if (id != 0)
                {
                    //向数据库中修改数据
                    string stradd = string.Format("UPDATE dbo.UserInfo SET UserName='{0}',UserSex={1},UserAge={2},UserEmail='{3}' WHERE UserId={4}",name,sex,age,email,id);
                    //创建一个命令对象
                    SqlCommand cmd = new SqlCommand(stradd, Program.con);
                    //打开连接
                    Program.con.Open();
                    //返回受影响的行数
                    int count = cmd.ExecuteNonQuery();
                    Console.WriteLine("修改成功，{0}条记录", count);
                }
                else
                {
                    Console.WriteLine("请输入修改人的id！");
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            finally {
                //关闭连接
                Program.con.Close();
            }
        }

    }
}
