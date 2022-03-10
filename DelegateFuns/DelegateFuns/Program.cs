using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DelegateFuns
{

    public delegate void CalculatorDel();
    class Calculator
    {
        public event CalculatorDel RunCalculator;

        public void Calculate()
        {
            Console.WriteLine("Running Calculator");
            RunCalculator();
            //RunCalculator2();

        }
    }
    class Program
    {
        static void r()
        {
            Calculator c = new Calculator();
            c.RunCalculator += C_RunCalculator1;
            c.RunCalculator += C_RunCalculator2;
            c.Calculate();
        }

        private static void C_RunCalculator1()
        {
            Console.WriteLine("Custom code");
        }
        private static void C_RunCalculator2()
        {
            Console.WriteLine("Custom Code 2");
        }

    }
}


