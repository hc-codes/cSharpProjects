using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate2
{
    delegate int Power(int a);
    class Program
    {
        
        static int Cube(int x)
        {
            return x * x * x;
        }
        static int Square(int x)
        {
            return x * x;
        }

        static void Main(string[] args)
        {
            Power n1, n2;
            n1 = new Power(Square);
            n2 = Cube;
            int a = 10;
            Console.WriteLine($"Square = {n1(a)}  and  Cube = {n2(a)}");
        }
    }
}
