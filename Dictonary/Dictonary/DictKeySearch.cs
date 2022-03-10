using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictonary
{
    class DictKeySearch
    {
        public void DictSearch()
        {
            var data = new Dictionary<string, string>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter The Country Name");
                string key = Console.ReadLine();
                Console.WriteLine("Enter The Capital");
                string cap = Console.ReadLine();
                data.Add(key, cap);
            }
            Console.WriteLine("The Current Key & Value in Dict...");
            foreach (var item in data)
            {

                Console.WriteLine($"Country: {item.Key} And its Capital is {item.Value}");
            }
            Console.WriteLine("Enter The Country to Search");
            string ks = Console.ReadLine();
            foreach (var item in data)
            {
                if (item.Key == ks)
                    Console.WriteLine($"\nCountry: {item.Key} And its Capital is {item.Value}");
            }
        }
    }
}
