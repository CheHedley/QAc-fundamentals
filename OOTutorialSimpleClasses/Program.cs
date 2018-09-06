using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTutorialSimpleClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Square(10);
            var a = s.Area();
            Console.WriteLine($"The area is {a} sq. metres");

            var c = new Circle(10d);
            double p = c.Perimeter();
            double a1 = c.Area();

            Console.WriteLine(c);//print an object and tell me its internal state
        }
    }
}
