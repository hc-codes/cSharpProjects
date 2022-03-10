using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Subject
    {

        public double Maths { get; set; }
        public double Physics { get; set; }


    }
    class Student : Subject
    {
        public string Name { get; set; }
        public string Id { get; set; }

    }
    class Program
    {
        static void Main()
        {
            Student[] s = new Student[20];
            for (int i = 0; i < 2; i++)
            {
                Student s1 = new Student();
                Console.WriteLine($"Enter Name of {i + 1} th Student");
                s1.Name = Console.ReadLine();
                Console.WriteLine($"Enter ID of {i + 1} th Student");
                s1.Id = Console.ReadLine();
                Console.WriteLine($"Enter the Marks of Maths For {s1.Name}");
                s1.Maths = double.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the Marks of Physics For {s1.Name}");
                s1.Physics = double.Parse(Console.ReadLine());
                s[i] = s1;

            }
            double[] total = new double[2];
            Console.WriteLine("Students Details");
            for (int i = 0; i < 20; i++)
            {
                if (s[i]?.Name == null)
                    break;
                total[i] = s[i].Maths + s[i].Physics;
                Console.WriteLine($"Id: {s[i].Id}, Name: {s[i].Name}, Maths= {s[i].Maths}, Physics= {s[i].Physics} Total= {total[i]}");
            }

            Console.WriteLine("\n-------STUDENTS WHO SCORED MORE THAN 50 MARKS-------");
            for (int i = 0; i < 20; i++)
            {
                if (s[i]?.Name == null)
                    break;
                if (total[i] < 50)
                {
                    s[i].Name = null;
                    s[i].Id = null;
                    s[i].Maths = default;
                    s[i].Physics = default;
                    total[i] = default;

                }
            }
            for (int i = 0; i < 20; i++)
            {
                if (s[i]?.Name == null)
                    continue;
                Console.WriteLine($"Id: {s[i].Id}, Name: {s[i].Name}, Maths= {s[i].Maths}, Physics= {s[i].Physics} Total= {total[i]}");
            }


        }
    }
}
