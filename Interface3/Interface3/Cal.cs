using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    public interface Iadd
    {
        void Add(int a, int b);

    }
    public interface Isub
    {
        void Sub(int a, int b);
    }
    public class Cal : Iadd, Isub
    {
        public void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }

}
