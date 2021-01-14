using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : Shape
    {
        private readonly int sideLength;
        private readonly char pen;
       
        public Square(int sideLength, char pen)
        {
            this.sideLength = sideLength;
            this.pen = pen;
        }
        public void Draw()
        {
            for (int i = 0; i < sideLength; i++)
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
            return sideLength * sideLength;
        }

        public int GetPerimeter()
        {
            return sideLength * 4;
        }
    }
}
