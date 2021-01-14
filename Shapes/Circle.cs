using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Circle : Shape
    {
        protected readonly int radius;
        protected readonly char pen;

        public Circle(int radius, char pen)
        {
            this.radius = radius;
            this.pen = pen;
        }
        public abstract void Draw();

        public int GetArea()
        {
            return (int)(radius * radius * Math.PI);
        }

        public int GetPerimeter()
        {
            return (int)(radius * 2 * Math.PI);
        }
    }
}
