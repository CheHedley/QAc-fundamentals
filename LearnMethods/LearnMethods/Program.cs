using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //invoke the method (PrintGreeting)
            /*var users = new List<string>
            {
                "Joe",
                "Jack",
                "Jess"
            };

            var greetings = PrintGreeting(users);*/
            //PrintGreeting("Che");
            //PrintGreeting("John", "Bonjour");
            //CountDown(10);
            //DisplayCoordinates(-2, 100);
            //MultiplicationMethod(10, 5);
            //ModulusMethod(5);
            //IsValueOdd(9);
            //GetLength(John);
            //PrintRightTree(10);
            //PrintLeftTree(10);
            ulong result = ComputeFactorial(50);
            
         

        }
        //private static void PrintComleteTree()
        private static void PrintRightTree(int numberOfStars)
        {
            for (int i = 1; i < numberOfStars; i++)
            {
                PrintStars(i);
            }
        }
        private static void PrintLeftTree(int numberOfStars)
        {
            for (int i = 1; i <= numberOfStars; i++)
            {
                var tabs = new String('\t', (numberOfStars - i)/2);
                Console.Write(tabs);
                PrintStars(i);
            }
        }

        private static void PrintStars(int numberOfStars)
        {
            for (int i = 1; i < numberOfStars; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
        private static void PrintGreeting(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
        /*private static string PrintGreeting(List<String> users)
        {
            var t = string.Empty;
            foreach (var user in users)
            {
                t = t + $"Hello {user}, ";
            }
        }
        */
        private static void PrintGreeting(string name, string localGreeting)
        {
            Console.WriteLine($"{localGreeting} {name}");
        }
        private static void CountDown(int x)
        {
            for (int i = x; i >= 0; i--)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }

        private static void DisplayCoordinates(int m, int c)
        {
            for(int i = 0; i <= c; i++)
            {
                var y = m * i + 100;
                Console.WriteLine($"While x = {i}, y = {y}");
            }

        }
        private static int MultiplicationMethod(int x, int y)
        {
            var total = x * y;
            return total; 
        }
        private static double ModulusMethod(double y)
        {
            double modulus = y % 2;
            return modulus;
        }
        private static bool IsValueOdd(int num)
        {
            return num % 2 == 1;
        }
        //private int GetLength(string name)
        /*
        private static int ComputeFactorial(int k)
        {
            int result = 1;
            for (int i = 2; i <= k; i++)
            {
                result *= i;
            }
            return result;
        }
        */
        static ulong ComputeFactorial(ulong k)
        {
            if(k > 0)
            {
                return k * ComputeFactorial(k - 1);
            }
            return 1;
        }
    }
}
