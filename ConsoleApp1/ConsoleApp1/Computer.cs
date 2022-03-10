using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computer
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int? Price { get; set; }
    }
    class Program2
    {
        public static void Run()
        {
            //WebBrowser obj = new WebBrowser();
            //obj.WebMenu();
            Computer[] comp = new Computer[5];
            for (int i = 0; i < 5; i++)
            {
                Computer c = new Computer();
                if (i % 2 == 1)
                    continue;

                Console.WriteLine("Enter Computer Name");
                c.Name = Console.ReadLine();
                //Console.WriteLine("Enter Computer Brand");
                //c.Brand = Console.ReadLine();
                //Console.WriteLine("Enter Computer Price");
                //c.Price = int.Parse(Console.ReadLine());
                comp[i] = c;
            }
            foreach (var item in comp)
            {
                if (item?.Name == null)
                    continue;
                else
                    Console.WriteLine($"Name: {item?.Name}");
            }
            Computer[] comp1 = new Computer[5];
            int count = 0;
            for (int i = comp.Length - 1; i >= 0; i--)
            {
                Computer c = new Computer();
                if (comp[i]?.Name == null)
                    continue;
                c.Name = comp[i].Name;
                comp1[count] = c;
                count++;
            }
            Console.WriteLine("Elements in Reverse Order");
            foreach (var item in comp)
            {
                if (item?.Name == null)
                    continue;
                else
                    Console.WriteLine($"Name: {item?.Name}");
            }
        }
    }
}
