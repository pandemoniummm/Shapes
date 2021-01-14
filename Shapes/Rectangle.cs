using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private readonly int sideLength;
        private readonly int sideWidth;
        private readonly char pen;
   
        public Rectangle(int sideLength, int sideWidth, char pen)
        {
            this.sideLength = sideLength;
            this.sideWidth = sideWidth;
            this.pen = pen;
        }
        public void Draw()
        {
            for (int i = 0; i < sideWidth; i++)
            {
                for (int j = 0; j < sideLength; j++)
                {
                    Console.Write(pen + " ");
                }
                Console.WriteLine();
            }
        }

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
