using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inner
{
    class Program
    {
        class InnerProgram
        {
            public void TestInner()
            {
                Console.WriteLine("Inner test");
            }
        }
        static void Main(string[] args)
        {
            Program.InnerProgram inner = new Program.InnerProgram();
            inner.TestInner();
        }
    }
}
