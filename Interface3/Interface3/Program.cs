using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    class Student
    {
        public string Name { get; set; }
        public int Age  { get; set; }
        public void Display()
        {
            Console.WriteLine($"Name: {Name} Age: {Age}");
        }

    }
    class Employee
    {
        public string Name { get; set; }
        public int Eid { get; set; }
        public int Age { get; set; }
        public void Display()
        {
            Console.WriteLine($"Name: {Name} Eid: {Eid} Age: {Age}");
        }

    }
    
    class Program
    {

        static void Main(string[] args)
        {
            dynamic[] people = new dynamic[20];
            for(int i = 0; i < 2; i++)
            {
                Console.WriteLine("1. Student 2.Employee");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Student s = new Student();
                        Console.WriteLine("Enter Name");
                        s.Name = Console.ReadLine();
                        Console.WriteLine("Enter Age");
                        s.Age = int.Parse(Console.ReadLine());
                        people[i] = s;
                        break;
                    case 2:
                        Employee e = new Employee();
                        Console.WriteLine("Enter Name");
                        e.Name = Console.ReadLine();
                        Console.WriteLine("Enter Name");
                        e.Eid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Age");
                        e.Age = int.Parse(Console.ReadLine());
                        people[i] = e;
                        break;
                    default:
                        break;
                }
            }

            foreach (var item in people)
            {
                
                if (item == null)
                    break;
                item.Display();
              //  if (item.GetType() == typeof(Student))
                    
                    //Console.WriteLine($"{item.Name}, {item.Age}");
                //else
                    //Console.WriteLine($"{item.Name},{item.Eid} {item.Age}");
            }

        }
    }
}
