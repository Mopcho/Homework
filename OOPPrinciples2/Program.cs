using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinciples2
{
    class Program
    {
        static void Main()
        {

            List<Shape> shapes = new List<Shape>();

            Shape triangle = new Triangle(10, 6);

            Square square = new Square(10);

            Rectangle rectangle = new Rectangle(10, 4);

            shapes.Add(triangle);
            shapes.Add(square);
            shapes.Add(rectangle);


            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
                Console.WriteLine(shape.GetType());

            }

        }
    }
}
