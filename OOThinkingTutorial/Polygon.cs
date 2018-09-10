using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOThinkingTutorial
{
    public abstract class Polygon
    {
        protected int numberOfSides;
        public abstract double Area();
        public abstract double Perimeter();
        public double sideA;
        public Polygon(int numberOfSides, double sideA)
        {
            this.sideA = sideA;
            this.numberOfSides = numberOfSides;
        }

        public override string ToString()
        {
            return $"The total number of sides is {numberOfSides}. The perimeter of the square is {Perimeter()} and the area is {Area()}sq.m.";
        }
    }
}
