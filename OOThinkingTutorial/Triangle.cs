using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOThinkingTutorial
{
    public class Triangle:Polygon
    {
        public double sideB;
        public double sideC;
     
    

        public Triangle(int numberOfSides, double sideA, double sideB, double sideC):base(numberOfSides, sideA)
        {
            this.numberOfSides = numberOfSides;
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }


        public void CheckGeometry()
        {
            //throw new TriangleException ("Invalid geometry")
            if (!((sideA + sideB > sideC) && (sideC + sideB > sideA) && (sideA + sideC > sideB)))
                throw new TriangleException("Invalid geometry");
          
        }

        public override double Area()
        {
            double s = (sideA + sideB + sideC) / 2;
            return Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        }

        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }
    }
}
