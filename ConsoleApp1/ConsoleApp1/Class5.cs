using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class5
    {
        public void fun()
        {
            int[] a = new int[5];
            int c = 2;
            for (int i = 0; i < 5; i++)
            {
                a[i] = c;
                c = c + 2;
                Console.WriteLine(a[i]);
            }
        }
    }
}
