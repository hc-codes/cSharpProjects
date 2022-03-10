using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OverLoadingExmp
{
    public class Area
    {
        string ch;
        public void Menu()
        {
            do
            {
                
                double x, y;
                Console.WriteLine("\n\t\tEnter the Choice to Find Area");
                Console.WriteLine("\n\t---------------------------------------------------");
                Console.Write("\n\t1. Square 2. Rectangle 3. Circle 4. Triangle | 'q' to quit: ");
                ch = Console.ReadLine();
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                switch (ch)
                {
                    case "1":
                        Console.Write("\n\tEnter The Side Of The Square: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"\n\tArea of Square With Side: {a} = {FindArea(a)}");
                        break;
                    case "2":
                        Console.Write("\n\tEnter The Length Of The Rectangle: ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\n\tEnter The Breadth Of The Rectangle: ");
                        y = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"\n\tArea of Rectangle With Length: {x}, Breadth {y} = {FindArea(x, y)}");
                        break;
                    case "3":
                        Console.Write("\n\tEnter The Radius Of The Circle: ");
                        x = double.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"\n\tArea of Circle With Radius: {x} = {FindArea(x)}");
                        break;
                    case "4":
                        Console.Write("\n\tEnter The Height Of The Triangle: ");
                        float h = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.Write("\n\tEnter The Base Of The Triangle: ");
                        float b = float.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine($"\n\tArea of Triangle With Height: {h}, Base {b} = {FindArea(b, h)}");
                        break;
                    case "q":
                        Console.WriteLine("Exit Successful !!!");
                        break;
                    default:
                        Console.WriteLine("\nInvalid Choice !!!");
                        break;
                }
                Console.ResetColor();
                Console.WriteLine("\n\t-------------------------------------------------");
                Thread.Sleep(2000);
                Console.Clear();
            } while (ch != "q");
        }
        public int FindArea(int a) => a * a;
        public double FindArea(double length, double breadth) => length * breadth;
        public double FindArea(double radius) => Math.PI * radius * radius;
        public float FindArea(float bs, float hgt) => bs * hgt / 2;

    }
}
