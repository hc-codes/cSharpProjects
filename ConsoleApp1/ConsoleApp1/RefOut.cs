using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class RefOut
    {
        public void CallingFunctions()
        {
            /*int @switch = 5;
            Console.WriteLine(@switch);*/
            int a= 5;
            var obj = new RefOut();
            obj.DoubleUsingOut(5, out int d);
            Console.WriteLine("Double Using Out=" + d);
            Console.WriteLine("Double Using Ref=" + obj.DoubleUsingRef(ref a));
        }
        public void DoubleUsingOut(int a, out int d) => d = a * 2;
        public int DoubleUsingRef(ref int a) => a * 2;
    }
}
