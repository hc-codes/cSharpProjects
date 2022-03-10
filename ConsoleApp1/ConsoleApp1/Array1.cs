using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Array1
    {
        public void ArraySum()
        {
            Console.WriteLine("Enter Row size");
            int m= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Col size");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[m, n];
            int[,] b = new int[m, n];
            int c = 1;
            Console.WriteLine("Enter First Array");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter {c}th Array Element");
                    a[i,j]= int.Parse(Console.ReadLine());
                    c++;
                }
                
            }
            c = 1;
            Console.WriteLine("Enter Second Array");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine($"Enter {c}th Array Element");
                    b[i, j] = int.Parse(Console.ReadLine());
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
            Console.WriteLine("Second Array...".ToUpper());
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("sum");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(a[i, j]+b[i,j]+" ");
                }
                Console.WriteLine();
            }
            
        }
        public void ArraySort(int [] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])  //6,4,1,0,7 (5) 0,1,4,6,7
                    {                       //4,1,0,6,7 
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }

            }

            Console.WriteLine("Sorted");
            foreach (var item in a)
            {
                Console.Write(item + " ");

            }
        }
    }
}
