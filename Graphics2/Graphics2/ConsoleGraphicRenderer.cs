using GraphicsLib;
using GraphicsLib2;
using System;

namespace Graphics2
{
    public class ConsoleGraphicRenderer : IGraphicRenderer
    {
        public void Render(Shape shape)
        {
            if (typeof(Circle) == shape.GetType())
            {
                RednderCircle(shape);
                return;
            }
            if (typeof(Rectangle) == shape.GetType())
            {
                RenderRectangle(shape);
                return;
            }
        }

        private void RenderRectangle(Shape shape)
        {
            Point p = shape.Location;
            Rectangle r = (Rectangle)shape;
            Console.WriteLine("Rectangle: at " + p.ToString() + " - Length = " + r.Length + ", Breadth = " + r.Breadth);
        }

        private void RednderCircle(Shape shape)
        {
            Point p = shape.Location;
            Circle circle = (Circle)shape;
            Console.WriteLine("Circle: at " + p.ToString() + " - radius = " + circle.Radius);
        }
    }
}
