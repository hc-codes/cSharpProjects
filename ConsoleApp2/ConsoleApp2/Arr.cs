using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Arr
    {
        int n = 0;
        int[] a;
        public void Read()
        {
            Console.WriteLine("Enter Array Size");
            n = int.Parse(Console.ReadLine());
            a = new int[n];
            Console.WriteLine("Enter Array Elements");
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
        }

        public void View()
        {
            Console.WriteLine("--- Your Array ---");

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        public void Reverse()
        {
            Console.WriteLine("Your Array in Reverse Order");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }

        public void Count()
        {
            Console.WriteLine("Enter the item to be searched");
            int item = int.Parse(Console.ReadLine());
            int c = 0;
            foreach (var elem in a)
            {
                if (item == elem)
                    c++;
            }
            if (c == 0)
                Console.WriteLine("Element Not Found !!!");
            else
            {
                Console.Write(value: $"Item: {item} Found {c} times in the array: ");
                View();
            }
        }

        internal void SortArr()
        {
            var sortedArr = a;
            Array.Sort(sortedArr);
            foreach (var item in sortedArr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

        }

        internal void Total()
        {
            int s = 0;
            foreach (var item in a)
            {
                s += item;
            }
            Console.WriteLine("Sum of elements = " + s);
        }

        public void Menu()
        {
            Arr arr = new Arr();
            while (true)
            {
                Console.WriteLine("1. Enter Array elements 2. Display Array 3. Reverse Array 4. Search for Count 5. Sort 6. Sum of elements");
                string ch = Console.ReadLine();
                switch (ch)
                {
                    case "1":
                        arr.Read();
                        break;
                    case "2":
                        arr.View();
                        break;
                    case "3":
                        arr.Reverse();
                        break;
                    case "4":
                        arr.Count();
                        break;
                    case "5":
                        arr.SortArr();
                        break;
                    case "6":
                        arr.Total();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
