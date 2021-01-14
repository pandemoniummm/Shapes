using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class SquareConsole : Square
    {
        private readonly char pen;
        public SquareConsole(int sideLength, char pen) : base(sideLength)
        {
            this.pen = pen;
        }
        public override void Draw()
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
    }
}
