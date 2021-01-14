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

        public Circle(int radius)
        {
            this.radius = radius;         
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
