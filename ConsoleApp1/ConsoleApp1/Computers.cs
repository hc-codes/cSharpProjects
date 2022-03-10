using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Computers
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int? Price { get; set; }
    }
    class Program1
    {
        public static void ComputerRun()
        {
            //WebBrowser obj = new WebBrowser();
            //obj.WebMenu();
            Computers[] comp = new Computers[5];
            for (int i = 0; i < 5; i++)
            {
                Computers c = new Computers();
                if (i % 2 == 1)
                    continue;

                Console.WriteLine("Enter Computer Name");
                c.Name = Console.ReadLine();
                Console.WriteLine("Enter Computer Brand");
                c.Brand = Console.ReadLine();
                Console.WriteLine("Enter Computer Price");
                c.Price = int.Parse(Console.ReadLine());
                comp[i] = c;
            }
            foreach (var item in comp)
            {
                if (item?.Name == null)
                    continue;
                else
                    Console.WriteLine($"Name: {item?.Name} Brand: {item.Brand} Price: {item.Price}");
            }
            Console.WriteLine("Enter The brand to Display its Computers");
            string s = Console.ReadLine();
            int f = 0;
            foreach (var item in comp)
            {
                if (item?.Brand.ToLower() == s)
                {
                    Console.WriteLine($"Name: {item?.Name} Brand: {item.Brand} Price: {item.Price}");
                    f = 1;
                }
            }
            if (f == 0)
                Console.WriteLine("No Computers of the Brand Found");
        }
    }
}