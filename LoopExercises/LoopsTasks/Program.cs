using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //TuitionCalculation57();
            //VowelsAndConstenants549();
           
        }

        private static void VowelsAndConstenants549()
        {
            Console.WriteLine("Please enter a word or phrase");
            var vowelCount = 0;
            var nonVowelCount = 0;
            var input = Console.ReadLine();
          
            if(!input.Equals(string.Empty))
            {
                var normalisedinput = input.ToUpper().Replace(" ", string.Empty);
                char[] letters = normalisedinput.ToCharArray();
                foreach ( var letter in letters)
                {
                    if (letter == 'A')
                        vowelCount++;
                    else if (letter == 'E')
                        vowelCount++;
                    else if (letter == 'I')
                        vowelCount++;
                    else if (letter == 'O')
                        vowelCount++;
                    else if (letter == 'U')
                        vowelCount++;
                    else nonVowelCount++;
                }
                Console.WriteLine($"The number of vowels is: {vowelCount}");
                Console.WriteLine($"The number of constenants is: {nonVowelCount}");
            }
        }

        private static void TuitionCalculation57()
        {
            double totalIncrement = 1;
            double tenYearIncrement = 0;
            double fourYearIncrement = 0;

            for (int i = 1; i <= 14; i++)
            {
                totalIncrement *= 1.05;
                if (i==10)
                {
                    tenYearIncrement = totalIncrement;
                }
                if (i > 10)
                {
                    fourYearIncrement += totalIncrement;
                }
            }
            Console.WriteLine($"The total cost of four years tuition, in ten years time is : {10000*fourYearIncrement:C}");
            Console.WriteLine($"The cost of tuition after ten years is: {10000*tenYearIncrement:C}");
        }
    }
}
