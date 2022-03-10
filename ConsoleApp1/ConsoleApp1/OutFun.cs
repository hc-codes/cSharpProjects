using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class OutFun
    {
        public void Fun()
        {
            int a = 10;
            int b = 20;
            int s;
            int pro;
            SumPro(a, b, out s,out pro);
            Console.WriteLine($"Sum = {s} and Product = {pro}");
        }
        public void SumPro(int a, int b, out int sum, out int prod)
        {
            sum = a + b;
            prod = a * b;
        }
    }
}
