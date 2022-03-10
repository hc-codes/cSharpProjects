using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Shape
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public double Radius { get; set; }
        public abstract void Perimeter();
        public abstract void Area();
    }
    class Rectangle : Shape
    {

        public override void Perimeter()
        {
            
            Console.WriteLine($"Perimeter of rectangle = {2 * (Length + Width)}");
        }
        public override void Area()
        {
            Console.WriteLine($"Area of rectangle = {Length * Width}");
        }
    }
    class Circle : Shape
    {

        public override void Perimeter()
        {

            Console.WriteLine($"Perimeter of circle = {2 * Math.PI * Radius}");
        }
        public override void Area()
        {
            Console.WriteLine($"Area of circle = {Math.PI * Radius * Radius}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample s = new Sample();
            s.Get();
            /*Rectangle r = new Rectangle();
            Console.WriteLine("Enter length: ");
            r.Length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter width: ");
            r.Width = int.Parse(Console.ReadLine());
            r.Perimeter();
            r.Area();
            Circle c = new Circle();
            Console.WriteLine("Enter radius: ");
            c.Radius = int.Parse(Console.ReadLine());
            c.Perimeter();
            c.Area();*/
        }
    }
}
