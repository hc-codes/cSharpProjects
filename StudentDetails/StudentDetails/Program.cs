using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{
    public class School2
    {
        public string SchoolName { get; set; }
        public string Address { get; set; }
       

    }
    public class Student2 : School2
    {
        public string StdName { get; set; }
        public string Email { get; set; }
        public string Dob { get; set; }
        

        
    }



    class Program
    {
        static void Main(string[] args)
        {
            
            Student2[] s = new Student2[20];
            for(int i = 0; i < 1; i++)
            {
                Student2 std = new Student2();
                Console.WriteLine("Enter Student Name");
                std.StdName = Console.ReadLine();
                Console.WriteLine("Enter Student Email");
                std.Email = Console.ReadLine();
                Console.WriteLine("Enter Student DOB");
                std.Dob = Console.ReadLine();
                Console.WriteLine("Enter Student School Name");
                std.SchoolName = Console.ReadLine();
                Console.WriteLine("Enter Student Address");
                std.Address = Console.ReadLine();
                s[i] = std;
            }
            Console.WriteLine("\n---STUDENT DETAILS---");
            Console.WriteLine("\n\tSTD NAME EMAIL DOB SCHOOL SCHOOL ADDRESS");
            foreach (var item in s)
            {
                if (item?.StdName == default)
                    break;
                string details = $"\n\t{item.StdName}, {item.Email}, {item.Dob}, {item.SchoolName}, {item.Address}";
                Console.WriteLine(details);
            }

        }
    }
}

/*
Student std = new Student();
std.Name = "std1";
std.Email = "stdEmail";
std.DateOfBirth = "28/08/1998";
Console.WriteLine(std.GetDetails());*/