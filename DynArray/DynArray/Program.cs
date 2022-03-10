using MyCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray o = new MyArray();
            for (int i = 0; i < 8; i++)
            {
                o.Add(Console.ReadLine());

            }
            o.Show();
        }
    }
}
