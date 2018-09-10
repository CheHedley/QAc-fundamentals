using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOThinkingTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon square = new Square(4, 5);
            square.Area();
            displayPolygon(square);

            Polygon triangle = new Triangle(3, 5);
            triangle.Area();
            displayPolygon(triangle);

        }
        public static void displayPolygon(Polygon p)
        {
            p.Draw();
        }

    }
}
