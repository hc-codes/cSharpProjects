using GraphicsLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsLib2
{
    public abstract class Shape
    {
        public Point Location { get; set; }

        public void Move(int dx, int dy)
        {
            Point newLocation = new Point(this.Location.X + dx, this.Location.Y + dy);
            this.Location = newLocation;
        }
        public abstract double Area();
    }
}
