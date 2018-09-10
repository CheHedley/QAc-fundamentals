using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOThinkingTutorial
{
    class Square : Polygon
    {
        public Square(int numberOfSides, double sideA) : base(numberOfSides, sideA)
        {

        }

        public override double Area()
        {
            return Math.Pow(sideA, 2);
        }
        public override double Perimeter()
        {
            return sideA * numberOfSides;
        }
    }
}
