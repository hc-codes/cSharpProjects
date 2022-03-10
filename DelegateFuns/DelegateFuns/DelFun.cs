using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFuns
{
    public delegate void MyDelegate();

    class DelFun
    {
        static void Greet()
        {
            Console.WriteLine("Hello World");
        }
        static void SayHi()
        {
            Console.WriteLine("Hi");
        }

        static void run()
        {
            Console.WriteLine("1st round");
            MyDelegate del = Greet;
            del += SayHi;
            del(); //del.Invoke();
            Console.WriteLine("2nd round");
            del -= Greet;
            del();
        }
    }
}
