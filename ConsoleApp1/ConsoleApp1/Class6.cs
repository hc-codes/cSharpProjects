using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class6
    {
        public void fun()
        {
            int[] a = new int[5] { 50, 100, 150, 25, 0 };
            Console.WriteLine("Enter the number to search");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Array.BinarySearch(a, n));
            Console.WriteLine();
        }
    }
}
