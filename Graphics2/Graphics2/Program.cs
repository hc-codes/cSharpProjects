using Graphics2;
using GraphicsLib2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Circle c = new Circle();
            //c.Radius = 10;
            //Console.WriteLine("circum "+c.Circumference());
            //Console.WriteLine("Area "+c.Area());
            //Rectangle r = new Rectangle();
            //r.Length = 10;
            //r.Breadth = 20;
            //Console.WriteLine("Area " + r.Area());
            Shape[] shapes = new Shape[20];
            shapes[0] = new Circle
            {
                Radius = 5,
                Location = new GraphicsLib.Point(4, 8)
            };
            shapes[1] = new Rectangle
            {
                Length = 10,
                Breadth = 20,
                Location = new GraphicsLib.Point(5, 6)
            };
            shapes[2] = new Circle
            {
                Radius = 12,
                Location = new GraphicsLib.Point(1, 3)
            };
            IGraphicRenderer renderer = new ConsoleGraphicRenderer();
            for (int i = 0; i < 3; i++)
            {
                //  double area = shapes[i].Area();
                //   Console.WriteLine("For " + i + " th Area= " + area);
                renderer.Render(shapes[i]);     
            }

        }
    }
}
