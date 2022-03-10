using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDetails
{

    class TopScorer
    {
        public void StudentMark()
        {
            Student1[] s = new Student1[2];
            for (int i = 0; i < 2; i++)
            {
                Student1 s1 = new Student1();
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
            for (int i = 0; i < 2; i++)
            {
                total[i] = s[i].Maths + s[i].Physics;
                //if (total[i] >= 90)
                //    grade = "OS";
                //else if (total[i] >= 85)
                //    grade = "A+";
                //elseif
                Console.WriteLine($"Id: {s[i].Id}, Name: {s[i].Name}, Maths= {s[i].Maths}, Physics= {s[i].Physics} Total= {total[i]}");
            }
            int index = 0;
            double big = 0;
            Console.WriteLine("-------TOP SCORER DETAILS-------");
            for (int i = 0; i < 2; i++)
            {
                if (total[i] > big)
                {
                    big = total[i];
                    index = i;
                }
            }
            Console.WriteLine($"TOP SCORER IS { s[index].Name} WITH A TOTAL MARK OF {total[index]}");

        }
    }
}
