using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBConnect
{

    class Program
    {
        static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hari\source\repos\DBConnect\DBConnect\AppDB\Database1.mdf;Integrated Security=True";
        static string bookTableDDL = @"create table Books(
                                    Id integer primary key identity not null,
                                    Name varchar(200) not null,
                                    Author varchar(200) not null,
                                    Price float not null)";
        static void Main(string[] args)
        {

            try
            {
                //using (var conn = new SqlConnection(connectionString))
                //{
                //    SqlCommand command = new SqlCommand();
                //    command.Connection = conn;
                //    command.CommandText = bookTableDDL;
                //    conn.Open();
                //     command.ExecuteNonQuery();
                //    Console.WriteLine("Connection Established");
                //}

                //using (var conn = new SqlConnection(connectionString))
                //{
                //    conn.Open();
                //    for (int i = 0; i < 3; i++)
                //    {
                //        string name = Console.ReadLine();
                //        string author = Console.ReadLine();
                //        float price = float.Parse(Console.ReadLine());
                //        string insert = @"insert into Books(
                //                    Name,Author,Price) 
                //                    values('" + name + "'," + "'" + author + "'," + price + ")";
                //        SqlCommand command = new SqlCommand(insert, conn);
                //        command.ExecuteNonQuery(); 
                //    }
                //}


                using (var conn = new SqlConnection(connectionString))
                {
                    conn.Open();


                    string select = @"select * from Books";
                    SqlCommand command = new SqlCommand(select, conn);
                    SqlDataReader dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Console.WriteLine($"id: {dataReader.GetValue(0)}, Name: {dataReader.GetValue(1)}, Author: {dataReader.GetValue(2)}, Price: {dataReader.GetValue(3)}");
                    }
                    dataReader.Close();
                    conn.Close();

                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            /*
                   
             
             */

        }
    }
}






/*
 

 public abstract class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public BookStatus Status { get; set; }

        public abstract void Homepage(List<User> users, List<User> book);
    }
    public enum BookStatus
    {
        Request,
        Return,
        Approve,
        Reject,
        Reserve
    }
    public class Admin : User
    {
        public override void Homepage(List<User> users, List<User> book)
        {
            Console.WriteLine("Welcome to admin");
        }
    }
    public class Operations
    {
        public void GetRequest()
        {

        }
        public void ReturnRequest()
        {

        }
    }
    public class Student : User
    {
        public override void Homepage(List<User> users, List<User> book)
        {
            Console.WriteLine("Welcome to Student");
            
        }
    }
    public class Book
    {
        public string Name { get; set; } = "b1";
    }


 
 */