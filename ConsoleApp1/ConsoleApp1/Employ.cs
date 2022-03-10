using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Desg
    {
        Senior = 1,
        Junior = 2
    }

    class Employ
    {
        public string Name { get; set; }
        public Desg Desg { get; set; }
    }
    class Run
    {
        Employ[] emp = new Employ[20];
        Employ[] senior = new Employ[20];
        Employ[] junior = new Employ[20];
        int sc = 0;
        int jc = 0;
        public static void RunEmp()
        {
            Run p = new Run();
            p.ReadData();
            p.SplitData();
            //var seniorEmployee = allEmployees.Where(m => m.Role == Role.SeniorDeveloper).ToArray();
            //var juniorEmployee = allEmployees.Where(m => m.Role == Role.JuniorDeveloper).ToArray();
        }

        private void SplitData()
        {

            foreach (var item in emp)
            {
                if (item?.Name == null)
                    break;
                switch (item.Desg)
                {
                    case Desg.Senior:
                        senior[sc++] = item;
                        break;
                    case Desg.Junior:
                        junior[jc++] = item;
                        break;
                }
            }
            Console.WriteLine("Senior Data");
            foreach (var item in senior)
            {
                if (item?.Name == null)
                    break;
                Console.WriteLine($"Name: {item.Name}, Designation: {item.Desg}");
            }
            Console.WriteLine("Junior Data");
            foreach (var item in junior)
            {
                if (item?.Name == null)
                    break;
                Console.WriteLine($"Name: {item.Name}, Designation: {item.Desg}");
            }
        }

        public void ReadData()
        {

            for (int i = 0; i < 2; i++)
            {
                Employ e = new Employ();
                Console.WriteLine("Enter Name");
                e.Name = Console.ReadLine();
                Console.WriteLine("Enter Designation 1. Senior 2. Junior");
                e.Desg = (Desg)int.Parse(Console.ReadLine());
                emp[i] = e;
            }

        }
    }
}
