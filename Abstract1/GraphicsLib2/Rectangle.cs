using GraphicsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib2
{
    public class Rectangle : Shape
    {
        public int Length { get; set; }
        public int Breadth { get; set; }
        public override double Area() => Length * Breadth;
    }
}
