using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Class4
    {
        public void fun()
        {
            int x, y, z;

            var data = "a string";
            char[] ar = data.ToCharArray();
            string first = ar[0].ToString().ToUpper();
            ar[0] = first[0];
            data = new string(ar);
            Console.WriteLine(ar);

        }
    }
}
