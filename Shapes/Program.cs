using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape square = new SquareConsole(4, '#');
            Shape rectangle = new RectangleConsole(5,7, '$');
            Shape circle = new CircleConsole(3, '@');

            var shapes = new List<Shape> {square, rectangle, circle };

            Console.WriteLine("Draws all shapes");

            foreach (var shape in shapes)
            {
                shape.Draw();
                Console.WriteLine();
            }

            var sumArea = shapes.Sum(x => x.GetArea());

            Console.WriteLine($"Total the area of all shapes {sumArea}");

            var sumPerimeter= shapes.Sum(x => x.GetPerimeter());

            Console.WriteLine($"Total the perimeter of all shapes {sumPerimeter}");

            Console.ReadKey();
        }
    }
}
