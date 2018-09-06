using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTutorialSimpleClasses
{
    class Square
    {
        private double length;

        public Square(double k)
        {
            length = k;
        }
        public double Area()
        {
            return length * length;
        }
    }
}
