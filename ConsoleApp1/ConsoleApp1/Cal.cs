using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Cal
    {
        #region Simple Calc Menu
        public void Menu()
        {
            int x, y;
            int flag = 0;
            while (true)
            {
                
                Console.WriteLine("1.Addition 2.Substraction 3.Multiplication 4.Division 5.Exit");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Enter 1st Number");
                x= int.Parse(Console.ReadLine());
                Console.WriteLine("Enter 2d Number");
                y = int.Parse(Console.ReadLine());
               
                
                switch (ch)
                {

                    case '1':
                        Console.WriteLine($"{x} + {y} = " + Add(x, y));
                        break;
                    case '2':
                        Console.WriteLine($"{x} - {y} = " + Sub(x, y));
                        break;
                    case '3':
                        Console.WriteLine($"{x} * {y} = " + Mul(x, y));
                        break;
                    case '4':
                        Console.WriteLine($"{x} / {y} = " + Div(x, y));
                        break;
                    case '5':
                        Console.WriteLine("Exiting From The Calculator");
                        flag = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid Choice:");
                        break;
                }
                if (flag == 1)
                    break;
            }
        }
        #endregion

        #region Advanced Calc Menu
        public void Menuu()
        {
            int a = 0;
            int sum = 0;
            int flag = 0;
            while (true)
            {
                Console.WriteLine("Enter a choice 1.Addition 2.Subtraction 3.Multiplication 4.Division 5.Reset or \"Enter '6' to Exit\" ");
                int ch = int.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        Console.WriteLine("Enter the number ");
                        a = int.Parse(Console.ReadLine());
                        Add(a, ref sum);
                        Console.Write($"total = {sum} ");
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("Enter the number ");
                        a = int.Parse(Console.ReadLine());
                        Sub(a, ref sum);
                        Console.Write($"total = {sum} ");
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("Enter the number ");
                        a = int.Parse(Console.ReadLine());
                        Mul(a, ref sum);
                        Console.Write($"total = {sum} ");
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("Enter the number ");
                        a = int.Parse(Console.ReadLine());
                        Div(a, ref sum);
                        Console.Write($"total = {sum} ");
                        Console.WriteLine();
                        break;
                    case 5:
                        sum = 0;
                        Console.WriteLine("Total Reset To 0");
                        break;
                    default:
                        flag = 1;
                        break;
                }
                if (flag == 1)
                {
                    Console.WriteLine("Exiting From Calculator");
                    break;
                }
            }
        }
        #endregion
        static void Add(int a, ref int sum) => sum += a;
        static void Sub(int a, ref int sum) => sum -= a;
        static void Mul(int a, ref int sum) => sum *= a;
        static void Div(int a, ref int sum) => sum /= a;
        int Add(int a, int b) => a + b;
        int Sub(int a, int b) => a - b;
        int Mul(int a, int b) => a * b;
        int Div(int a, int b) => a / b;
    }
}
