using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassBasics
{
    public class Calculator
    {
        private int num1 = 0;
        private int num2 = 0;
        //public void ReadData()
        //{


        //    }

        /*    public Calculator(int n,int m)
        {
            C
        }*/
        public int Num1
        {
            get { return num1; }
            set
            {
                num1 = value;

            }
        }
        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public void Add()
        {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }
        public void Sub()
        {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }
        public void Mul()
        {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }
        public void Div()
        {
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");

        }

    }

    class CalMenu
    {
        public static void Menu()
        {
            Calculator p = new Calculator();
            Console.WriteLine("Enter Number 1");
            p.Num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2");
            p.Num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Add 2.Sub 3.Mul 4.Div");
            Console.WriteLine("Enter a Choice");
            int ch = int.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    p.Add();
                    break;
                case 2:
                    p.Sub();
                    break;
                case 3:
                    p.Mul();
                    break;
                case 4:
                    p.Div();
                    break;

            }

        }
    }
}
