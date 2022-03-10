using Shop.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            Product[] items = { 
            new Product{Id = 1, Category="grocery", Name="wheat", Price=100, Stock =100},
             new Product{Id = 2, Category="stationery", Name="pencil", Price=10, Stock =30},
              new Product{Id = 3, Category="grocery", Name="sugar", Price=15, Stock =10},
               new Product{Id = 4, Category="stationery", Name="pen", Price=10, Stock =20},
                new Product{Id = 5, Category="grocery", Name="rice", Price=50, Stock =100},
                 new Product{Id = 6, Category="candy", Name="kitkat", Price=20, Stock =17},
                  new Product{Id = 7, Category="drinks", Name="coffee", Price=10, Stock =30},
            };
            //var cats = items.Select(p => p.Category).Distinct();
            //foreach (var item in cats)
            //{
            //    Console.WriteLine(item);
            //}
            //var ps = items.Where(p => p.Category == "grocery");
            var ps = from p in items where p.Category == "grocery" select p;
            foreach (var item in ps)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-----------");
            //var ps2 = items.Where(p => p.Category == "grocery").OrderBy(p => p.Price);
            //foreach (var item in ps2)
            //{
            //    Console.WriteLine(item);
            //}
            //var ps2 = items.Where(p => p.Category == "grocery").OrderByDescending(p => p.Stock).ThenBy(p => p.Name);
            //foreach (var item in ps2)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
