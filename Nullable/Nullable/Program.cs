using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 10;
            object o = x;
        //    Console.WriteLine(o);
            int a = 20;
            // a = null;  //Cant assign null to a value type.
            int? b = 30;
            b = null; //b is nullable integer type.
            Nullable<int> c = 40;
            // int d = 10 + b;  As b can be null, it cannot be used in any integer type expression.
            // To use b in an expression we have to give a default value in case b is null.
            int d = 10 + b ?? 0;
            Console.WriteLine(d);
            b = 20;
            d = 10 + b ?? 0;
            Console.WriteLine(d);
            d = 10 + b == null ? 0 : (int)b;
        }
    }
}
