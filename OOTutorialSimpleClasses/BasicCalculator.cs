using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOTutorialSimpleClasses
{
    class BasicCalculator
    {
        private int k;
        private int j;

        public BasicCalculator(int x, int y)
        {
            k = x;
            j = y;
        }




        public int Subtract()
        {
            return k - j;
        }

        public static int Add(int x, int y)
        {
            return x + y;
        }

        internal int Subtraction(int v1, int v2)
        {
            return v1 - v2;
        }

        internal String Add(string v1, string v2)
        {
            return v1 + v2;
        }

        internal int Modulus(int v1, int v2)
        {
            return v1 % v2;
        }

        internal static bool IsEven(int v)
        {
            return (v % 2 == 0);
        }

        internal static int Multiplication(int v1, int v2)
        {
            return v1 * v2;
        }

        public double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
