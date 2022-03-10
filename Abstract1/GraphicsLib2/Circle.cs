using GraphicsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib2
{

    public class Circle : Shape
    {
        public int Radius { get; set; }

        //public double Circumference { get => 2 * Math.PI * Radius; }
        public double Circumference() => 2 * Math.PI * Radius;
        public override double Area() => Math.PI * Radius * Radius;



    }
}
