using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateFuns
{
    
    class FuncAndAction
    {
        static Func<int, int, float> sum;
        static Action<int, int> add;
        static float Sum(int x, int y)
        {
            return x + y;
        }
        static void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        static void Main(string[] args)
        {
            sum += Sum;
            var res = sum(5, 6);
            Console.WriteLine(res);
            add += Add;
            add(10, 20);
        }
    }
}
