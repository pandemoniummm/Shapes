using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class RectangleConsole : Rectangle
    {
        public RectangleConsole(int sideLength, int sideWidth, char pen) : base(sideLength, sideWidth, pen)
        {
        }
        public override void Draw()
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
    }
}
