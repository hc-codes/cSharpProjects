using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class7
    {
        void fun()
        {
            int?[] even = new int?[5];
            int?[] odd = new int?[5];
            Console.WriteLine("Enter Numbers...");
            for (int i = 0; i < 5; i++)
            {
                int n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    even[i] = n;
                    //                    odd[i] = null;
                }
                else
                {
                    //                  even[i] = null;
                    odd[i] = n;
                }
            }
            Console.WriteLine("Even Numbers...");
            for (int i = 0; i < 5; i++)
            {
                if (even[i] != default)
                    Console.Write(even[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Odd Numbers...");
            for (int i = 0; i < 5; i++)
            {
                if (odd[i] != default)
                    Console.Write(odd[i] + "  ");
            }
            Console.WriteLine();
        }
    }
}
