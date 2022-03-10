using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // ParamsUse o=new ParamsUse();
    //o.fun(array);
    class ParamsUse
    {
        static void fun(params int[] a)
        {
            Console.WriteLine("Elements Are...");
            int s=0;
            foreach (var item in a)
            {
                s += item;
            }
            Console.WriteLine(s);

        }
    }
}
