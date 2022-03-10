using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RefFun
    {
        public static void f()
        {
            int n = 5;
            Console.WriteLine("Main before calling=" + n);
            ChangeValue(ref n);
            Console.WriteLine("Main After calling=" + n);
            
        }
        private static void ChangeValue(ref int a)
        {
            Console.WriteLine("ChangeValue before Change=" + a);

            a = 10;
            Console.WriteLine("ChangeValue After Change=" + a);

        }
    }
}
