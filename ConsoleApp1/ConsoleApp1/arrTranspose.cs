using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class arrTranspose
    {
        public void trans()
        {

            Console.WriteLine("Enter Row size");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Col size");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int c = 1;
            Console.WriteLine("Enter First Array");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter {c}th Array Element");
                    a[i, j] = int.Parse(Console.ReadLine());
                    c++;
                }

            }
            Console.WriteLine("FirstArray...".ToUpper());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Transpose");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(a[j, i] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
