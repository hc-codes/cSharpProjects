using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib
{
    public class Point : object
    {
        public int X { get; }
        public int Y { get; }
        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public static Point operator +(Point p1, Point p2)
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;
            Point p = new Point(x, y);
            return p;
        }
    }
}
