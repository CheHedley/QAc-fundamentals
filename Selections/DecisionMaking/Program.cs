using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionMaking
{
    class Program
    {
        static string green = "GREEN";
        static string red = "RED";
        static string amber = "amber";

        static void Main(string[] args)
        {
            /*
            string colour = string.Empty;
            string gender = string.Empty;
            Console.WriteLine("Please enter your gender");
            gender = Console.ReadLine();
            Console.WriteLine("Please enter the colour of the traffic light");
            colour = Console.ReadLine();
            
            TrafficSignalWithSwitch(colour,gender);
            */
            
            //bool isEven = CheckIfNumberIsEven();
            //if(isEven)
            //Console.WriteLine("the number entered is even");
            //else
            //Console.WriteLine("the number entered is odd");
        }

        private static bool CheckIfNumberIsEven()
        {
            var r = new Random();
            return (Math.Ceiling(r.NextDouble() * 100) % 2 == 0);
        }

        private static void TrafficSignalWithSwitch(String colour, string gender)
        {
            switch (colour.ToUpper())
            {
                case "GREEN":
                    Console.WriteLine("GO");
                    break;
                case "RED":
                    Console.WriteLine("STOP");
                    if (gender.ToUpper() == "MALE")
                    {

                    }
                    break;
                case "AMBER":
                    Console.WriteLine("WAIT");
                    break;
                default:
                    Console.WriteLine("PROCEED WITH CAUTION");
                    break;

            }
        }
 
    }
}
