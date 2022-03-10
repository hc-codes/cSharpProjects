using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PhoneBook
    {
        public static void Phone() {
            var name = new string[50];
            var email = new string[50];
            var phone = new string[50];
            int c = 0;
            while (true)
            {
                Console.WriteLine("1. Enter details 2.View Details");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Enter(ref c, name, email, phone);
                        break;
                    case 2:
                        Console.WriteLine("Enter the name to be searched");
                        string s = Console.ReadLine();
                        ViewDetails(s, name, email, phone);
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;

                }
            }
        }
        static void Enter(ref int c, string[] name, string[] email, string[] phone)
        {
            Console.WriteLine("Enter Name");
            name[c] = Console.ReadLine();
            Console.WriteLine("Enter Email");
            email[c] = Console.ReadLine();
            Console.WriteLine("Enter Phone");
            phone[c] = Console.ReadLine();
            c++;
        }
        static void ViewDetails(string s, string[] name, string[] email, string[] phone)
        {
            int flag = 0;
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] == s)
                {
                    Console.WriteLine("Name : " + name[i]);
                    Console.WriteLine("Email : " + email[i]);
                    Console.WriteLine("Phone : " + phone[i]);
                    flag = 1;
                }
            }
            if (flag == 0)
                Console.WriteLine("Name Not Found");
        }
    }
}
