using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Rectangle : Shape
    {
        protected readonly int sideLength;
        protected readonly int sideWidth;      
   
        public Rectangle(int sideLength, int sideWidth)
        {
            this.sideLength = sideLength;
            this.sideWidth = sideWidth;           
        }
        public abstract void Draw();
       
        public int GetArea()
        {
            return sideLength * sideWidth;
        }

        public int GetPerimeter()
        {
            return (sideLength + sideWidth) * 2;
        }
    }
}
