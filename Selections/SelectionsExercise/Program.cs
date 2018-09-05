using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionsExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //Exercise31SolveQuadraticEquation();

            //Exercise34RandomMonth();

            //Exercise324PickACard();

            //Exercise319PerimeterOfATriangle();

            Exercise317RockPaperScissors();
        }

        private static void Exercise31SolveQuadraticEquation()
        {
            //string tokenisation
            Console.WriteLine("Enter the values of a, b, c:");
            var values = Console.ReadLine();
            String[] myValues = values.Split(new char[] {' '});
            if (myValues.Length != 3)
            {
                Console.WriteLine("Invalid arguments, enter the numerical values seperated by a space");
                return;
            }
            //creating an array an splitting it by spaces
            var x = double.TryParse(myValues[0], out double a);
            var y = double.TryParse(myValues[1], out double b);
            var z = double.TryParse(myValues[2], out double c);

            var d = Math.Pow(b, 2) - 4 * a * c; //Create b^2 - 4ac

            var r1 = (-b + Math.Sqrt(d)) / (2 * a);// quadratic formula positive variant
            var r2 = (-b - Math.Sqrt(d)) / (2 * a);// quadratic formula negative variant

            if (!(x&&y&&z))//check that tokenisation has worked
            {
                return;
            }
            if (d < 0) //if discriminant is negative there will be no roots
            {
                Console.WriteLine("The equation has no real roots");
                return;
            }
            else if (r1 == r2) //discriminant = 0 then one root
            {
                Console.WriteLine($"The equation has one root, root = {r1}");
            }
            else //discriminant is positive 2 roots
            {
                Console.WriteLine($"The equation has two roots, root 1 = {r1} and root 2 = {r2}");
            }



        }

        private static void Exercise34RandomMonth()
        {
            var monthNumber = (new Random()).Next(1, 12);
            string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Console.WriteLine(months[monthNumber - 1]);

            Console.WriteLine($"The month number is {monthNumber}");
            switch (monthNumber)
            {
                case 1: Console.WriteLine("January"); break;
                case 2: Console.WriteLine("February"); break;
                case 3: Console.WriteLine("March"); break;
                case 4: Console.WriteLine("April"); break;
                case 5: Console.WriteLine("May"); break;
                case 6: Console.WriteLine("June"); break;
                case 7: Console.WriteLine("July"); break;
                case 8: Console.WriteLine("August"); break;
                case 9: Console.WriteLine("September"); break;
                case 10: Console.WriteLine("October"); break; 
                case 11: Console.WriteLine("November"); break;
                case 12: Console.WriteLine("December"); break;
            }
        }

        private static void Exercise324PickACard()
        {
            String rank = "Ace,2,3,4,5,6,7,8,9,10,Jack,Queen,King";
            String suit = "Clubs,Spades,Hearts,Diamonds";
            String[] r = rank.Split(new char[] { ',' });
            String[] s = suit.Split(new char[] { ',' });

            int cardValue = new Random().Next(1, 13);
            int cardSuit = new Random().Next(1, 4);
            Console.WriteLine($"The card you picked if the {r[cardValue - 1]} of {s[cardSuit -1]}");
        }

        enum GAMEOPTIONS
        {
            Scissors, Rock, Paper
        }
        //Scissors 0, Rock 1, Paper 2
        private static void Exercise317RockPaperScissors()
        {
            Console.WriteLine("Rock, Paper, Scissors");
            Console.WriteLine("Please enter your selection");
            var computerOption = new Random().Next(0, 2);
            var x = Console.ReadLine();

            if (int.TryParse(x, out int humanOption))
            {
                if (humanOption == computerOption)
                {
                    var selection = Enum.GetName(typeof(GAMEOPTIONS), humanOption);
                    Console.WriteLine($"The computer is {selection}. You are {selection} too. It's a draw");
                }
                else if (computerOption.Equals(GAMEOPTIONS.Scissors))
                {
                    switch (humanOption)
                    {
                        case (int)GAMEOPTIONS.Paper: Console.WriteLine("The computer is scissors. You are paper. The computer won."); break;
                        case (int)GAMEOPTIONS.Rock: Console.WriteLine("The computer is scissors. You are rock. You won!"); break;
                    }
                }
                else if (computerOption.Equals(GAMEOPTIONS.Rock))
                {
                    switch (humanOption)
                    {
                        case (int)GAMEOPTIONS.Paper: Console.WriteLine("The computer is rock. You are paper. You won!"); break;
                        case (int)GAMEOPTIONS.Scissors: Console.WriteLine("The computer is rock. You are scissors. The computer won"); break;
                    }
                }
                else if (computerOption.Equals(GAMEOPTIONS.Paper))
                {
                    switch (humanOption)
                    {
                        case (int)GAMEOPTIONS.Scissors: Console.WriteLine("The computer is paper. You are scissors. You won!"); break;
                        case (int)GAMEOPTIONS.Rock: Console.WriteLine("The computer is paper. You are rock. The computer won"); break;
                    }
                }
              
            }
            else
            {
                Console.WriteLine("please select a valid option");
            }
        }

        private static void Exercise318CostOfShipping()
        {

        }

        private static void Exercise319PerimeterOfATriangle()
        {
            Console.WriteLine("Enter the sides of the triangle a, b, c");
            var input = Console.ReadLine();
            string[] values = input.Split(new char[] { ' ' });
            if(values.Length != 3)
            {
                Console.WriteLine("Unable to process, please provide sufficient input");
            }
            else
            {
                if (double.TryParse(values[0], out double a) && double.TryParse(values[1], out double b) && double.TryParse(values[2], out double c))
                {
                    if ((a + b > c) && (a + c > b) && (b + c > a))
                    {
                        Console.WriteLine($"The perimeter of the triangle with the sides {a}, {b} and {c} is {a + b + c}");
                    }

                }
            }
        }

        private static void Exercise333CompareCosts()
        {

        }
    }
}
