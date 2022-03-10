using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class IntArray
    {
        public void DisplayArray(params int [] a) //params keyword argmuents are optional.
        {
            Console.WriteLine("Your Array is...");
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");

            }
        }
    }
}
