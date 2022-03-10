using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DivOverloading
    {
        public void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public void Div(double x, double y)
        {
            Console.WriteLine(x / y);
        }
    }
}
