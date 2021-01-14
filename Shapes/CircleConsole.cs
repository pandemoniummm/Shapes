using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class CircleConsole : Circle
    {
        public CircleConsole(int radius, char pen) : base(radius, pen)
        {
        }
        public override void Draw()
        {
            Action<int, char> makeLine = (count, pen) => Enumerable.Range(0, count).ToList().ForEach(x => Console.Write(pen + " "));

            for (int i = 0; i < radius * 2 + 1; i++)
            {
                makeLine(i > radius ? i - radius : radius - i, ' ');
                makeLine(i > radius ? (radius * 2 - i) * 2 + 1 : i * 2 + 1, pen);
                Console.WriteLine();
            }
        }
    }
}
