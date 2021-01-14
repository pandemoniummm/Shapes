using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Square : Shape
    {
        protected readonly int sideLength;
       
        public Square(int sideLength)
        {
            this.sideLength = sideLength;          
        }
        public abstract void Draw();

        public int GetArea()
        {
            return sideLength * sideLength;
        }

        public int GetPerimeter()
        {
            return sideLength * 4;
        }
    }
}
