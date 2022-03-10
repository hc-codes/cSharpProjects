using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test4
{
    class InvalidUserException : Exception
    {
        public InvalidUserException() { }

        public InvalidUserException(string uName) : base(String.Format($"Invalid User Name: {uName} ")) { }
    }
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
    class Program
    {
        static User[] users = new User[10];
        static int userCount = 0;
        static string ch = "";
        static void Main(string[] args)
        {
            while (ch != "q")
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("\t\t------------Menu------------");
                Console.Write("\n\t1. Create new User 2.Login or 'q' to quit: ");
                ch = Console.ReadLine();
                Console.WriteLine();
                switch (ch)
                {
                    case "1":
                        CreateNewUser();
                        break;
                    case "2":
                        Login();
                        break;
                }
            }
        }
        private static void CreateNewUser()
        {

            User user = new User();
            Console.Write("\tEnter UserName: ");
            user.UserName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("\tEnter Password: ");
            user.Password = Console.ReadLine();
            Console.WriteLine();
            users[userCount++] = user;
            Console.WriteLine("\n\tUser Created Successfully...\n\n");

        }
        private static void Login()
        {

            try
            {
                User user = new User();
                Console.Write("\tEnter User Name: ");
                user.UserName = Console.ReadLine();
                Console.WriteLine();
                Console.Write("\tEnter Password: ");
                user.Password = Console.ReadLine();
                Console.WriteLine();
                ValidateUser(user);
            }
            catch (InvalidUserException e)
            {
                Console.WriteLine($"\n\t{e.Message}\n");
            }

        }

        private static void ValidateUser(User user)
        {
            
            int flag = 1;
            foreach (var item in users)
            {
                if (item?.UserName == null)
                    continue;
                if (item.UserName == user.UserName && item.Password == user.Password)
                {
                    flag = 1;
                    Console.WriteLine("\n\t\tLogin Successful !!!\n\n");
                    break;
                }
                else if (item.UserName == user.UserName && item.Password != user.Password)
                {
                    flag = 1;
                    Console.WriteLine("\n\tWrong Password !!! \tTry Again...\n");
                    break;
                }
                else
                    flag = 0;
            }
            if (flag == 0)
                throw new InvalidUserException(user.UserName);
        }


    }
}
