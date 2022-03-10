using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Box
    {
        public double Length;
        public double Width;
        public double Height;
        public double side;
        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }
        public Box(double size)
        {
            this.side = size;
        }
        public double FindVolume()
        {
            return Length * Width * Height;
        }
        public double FindArea()
        {
            return side * side * side;
        }
    
   
        public void Run()
        {
            Box obj1 = new Box(5, 4, 3);
            Box obj2 = new Box(20);

            Console.WriteLine("Volume =" + obj1.FindVolume());
            Console.WriteLine("Area =" + obj2.FindArea());

        }


    }
}
