using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ListWork
    {
        void fun()
        {

            List<int> l = new List<int>();
            int big = int.MinValue;
            Console.WriteLine("Enter the numbers to be entered");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter {i + 1} NUmbers");
                l.Add(int.Parse(Console.ReadLine()));
                if (l[i] > big)
                    big = l[i];
            }

            Console.WriteLine("Largest Number=== " + big);
        }
    }
}
