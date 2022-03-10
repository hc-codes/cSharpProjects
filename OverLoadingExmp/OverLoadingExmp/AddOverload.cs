using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OverLoadingExmp
{
    class AddOverload
    {
        string ch;
        public void Menu()
        {
            do
            {
                Console.WriteLine("\n\t\tEnter the Choice to continue");
                Console.WriteLine("\n\t-------------------------------------------------");
                Console.WriteLine("\t|\t\t\tMenu\t\t\t|");
                Console.WriteLine("\t-------------------------------------------------");
                Console.Write("\t1.Add two Numbers, 2. Concatanate two Strings: ");
                ch = Console.ReadLine();
                Console.WriteLine();
               
                switch (ch)
                {
                    case "1":
                        Console.Write("\n\tEnter the first number: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\n\tEnter the second number: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"\n\tSum: {a} + {b} = { Add(a, b)}");
                        break;
                    case "2":
                        Console.WriteLine("\n\tEnter the first string: ");
                        string x = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine("\n\tEnter the second string:");
                        string y = Console.ReadLine();
                        Console.WriteLine();
                        Console.WriteLine($"\n\tConcat: {x}  &  {y} = { Add(x, y)}");
                        break;
                    case "q":
                        Console.WriteLine("\nExit Successful !!!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice !!!");

                        break;
                }
                Console.WriteLine("\n\t-------------------------------------------------");
                Thread.Sleep(2000);
                Console.Clear();
            } while (ch!="q");
            
        }

        private string Add(string x, string y) => x + y;

        private int Add(int a, int b) => a + b;
    }
}
