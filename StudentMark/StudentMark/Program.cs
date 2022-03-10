using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentMark
{
    class LPClass : Student
    {
        public override double Total()
        {
            var total = Theory + 0.20 * Practical;
            return total;
        }
    }
    class UPClass : Student
    {
        public override double Total()
        {
            var total = Theory + 0.30 * Practical;
            return total;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var lp = new LPClass()
            //{
            //    Name = "a",
            //    Class = 8,
            //    Theory = 100,
            //    Practical = 100
            //};
            //var up = new UPClass()
            //{
            //    Name = "b",
            //    Class = 9,
            //    Theory = 100,
            //    Practical = 100
            //};
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(lp.Total());
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine(up.Total());
            int lpc = 0, upc = 0;
            Student[] s = new Student[5];
           
            IOrderedEnumerable<UPClass> resUp=null;
            IOrderedEnumerable<LPClass> resLp=null;
            for (int i = 0; i < 5; i++)
            {
                Student s1 = new Student();
                Console.WriteLine($"Enter Name of {i + 1} th Student");
                s1.Name = Console.ReadLine();
                Console.WriteLine($"Enter Class of {i + 1} th Student");
                s1.Class = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the Marks Theory For {s1.Name}: ");
                s1.Theory = int.Parse(Console.ReadLine());
                Console.WriteLine($"Enter the Marks Practical For {s1.Name}: ");
                s1.Practical = int.Parse(Console.ReadLine());
                s[i] = s1;
                if (s1.Class < 8)
                    lpc++;
                else
                    upc++;

            }
            LPClass[] lp1 = new LPClass[lpc];
            UPClass[] up1 = new UPClass[upc];
            double[] total = new double[2];
            Console.WriteLine("Students Details");
            lpc = 0;
            upc = 0;
            for (int i = 0; i < 5; i++)
            {
                if (s[i].Class < 8)
                {
                    var lpp = new LPClass();
                    lpp.Name = s[i].Name;
                    lpp.Class = s[i].Class;
                    lpp.Theory = s[i].Theory;
                    lpp.Practical = s[i].Practical;
                    lp1[lpc++] = lpp;
                    
                   // Console.WriteLine($"Class: {s[i].Class}, Name: {s[i].Name}, Theory= {lp1[i].Theory}, Practical= {lp1[i].Practical} Total= {lp1[i].Total()}");
                }
                else
                {
                    var upp = new UPClass();
                    upp.Name = s[i].Name;
                    upp.Class = s[i].Class;
                    upp.Theory = s[i].Theory;
                    upp.Practical = s[i].Practical;
                    up1[upc++] = upp;
                  //  Console.WriteLine($"Class: {s[i].Class}, Name: {s[i].Name}, Theory= {s[i].Theory}, Practical= {s[i].Practical} Total= {up1[i].Total()}");
                }
            }
            if (lp1[0].Name != null)
            {
                resLp = lp1.Where(m => m.Class < 8).OrderBy(m => m.Class);

                //Console.ForegroundColor = ConsoleColor.Yellow;
                //Console.BackgroundColor = ConsoleColor.DarkBlue;
                foreach (var item in resLp)
                {
                    if (item?.Name == null)
                        break;
                    Console.WriteLine($"Class: {item.Class}, Name: {item.Name}, Theory= {item.Theory}, Practical= {item.Practical} Total= {item.Total()}");

                }
            }
            //Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            if (up1[0]?.Name != null)
            {
                resUp = up1.Where(a => a.Class >= 8).OrderBy(a => a.Class);
                foreach (var item in resUp)
                {
                    if (item?.Name == null)
                        break;
                    Console.WriteLine($"Class: {item.Class}, Name: {item.Name}, Theory= {item.Theory}, Practical= {item.Practical} Total= {item.Total()}");

                }
            }
        }
    }
}

