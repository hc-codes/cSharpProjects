using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listworks
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static List<Student> students = new List<Student>();
        static void Main(string[] args)
        {
            for (int i = 0; i < 2; i++)
            {
                Student s = new Student();
                Console.WriteLine("Enter Name: ");
                s.Name = Console.ReadLine();
                Console.WriteLine("Enter Age: ");
                s.Age = int.Parse(Console.ReadLine());
                students.Add(s);
            }
            foreach (var item in students)
            {
                Console.WriteLine($"Name: {item?.Name}, Age: {item?.Age}");
            }

        }
    }
}
