using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elementary
{
    class Program
    {
        static void Main(string[] args)
        {


            Exercise22VolumeCylinder();

            Exercise223Driving();

            Exercise221BankInvestment();

            Exercise21TemperatureConversion();

            Exercise213CompoundInterest();

            Exercise214BodyMassIndex(); 

            Exercise217WindChill();

           

        }

        private static void Exercise217WindChill()
        {
            
        }

        private static void Exercise214BodyMassIndex()
        {
            Console.WriteLine("Please enter your height in inches");
            var x = Console.ReadLine();
            var isValidHeight = double.TryParse(x, out double height);

            Console.WriteLine("Please enter your weight in pounds");
            var y = Console.ReadLine();
            var isValidWeight = double.TryParse(y, out double weight);

            if (isValidHeight && isValidWeight)
            {
                double weightInKilograms = (weight * 0.45359237);
                weightInKilograms = Math.Round(weightInKilograms, 2);
                double heightInMetres = (height * 0.0254);
                heightInMetres = Math.Round(heightInMetres, 2);

                Console.WriteLine($"Your weight is {weightInKilograms}kg");
                Console.WriteLine($"Your height in metres is {heightInMetres}m");

                double bodyMassIndex = weightInKilograms / Math.Pow(heightInMetres, 2);
                bodyMassIndex = Math.Round(bodyMassIndex, 3);
                Console.WriteLine($"Your BMI is {bodyMassIndex}");
            }
            else
            {
                Console.WriteLine("Unable to calculate BMI based on information given. Please ensure you have entered your height and weight correctly.");
            }
        }

        private static void Exercise213CompoundInterest()
        {
            Console.WriteLine("Please enter the amount that you intend to save each month");
            var x = Console.ReadLine();
            var isValidAmount = double.TryParse(x, out double monthlySavings);
            double totalSavings = 0.0;

            Console.WriteLine("Your interest rate is 5%");
            double monthlyInterest = (0.05 / 12);

            int count = 0;

            while (count < 6)
            {
                totalSavings = totalSavings + monthlySavings;
                totalSavings = (totalSavings * (1 + monthlyInterest));
                Console.WriteLine($"Your total savings are currently {totalSavings:C}");

                count++;
            }
        
        }

        private static void Exercise21TemperatureConversion()
        {
            Console.WriteLine("Please enter a temperature in degrees Celsius, to convert to Fahrenheit");
            var x = Console.ReadLine();
            var isValidTemperature = double.TryParse(x, out double celsius);

            double fahrenheit = (9.0 / 5.0) * celsius + 32;

            if (isValidTemperature)
            {
                Console.WriteLine($"{celsius} degrees celsius is {fahrenheit} degrees fahrenheit");

            }
            else
            {
                Console.WriteLine("Please enter a valid value");
            }
        }

        private static void Exercise221BankInvestment()
        {
            Console.WriteLine("Enter investment amount");
            var x = Console.ReadLine();
            var isValidAmount = double.TryParse(x, out double amount);

            Console.WriteLine("Enter annual interest rate in percentage");
            var y = Console.ReadLine();
            var isValidRate = double.TryParse(y, out double interestRate);

            Console.WriteLine("Enter number of years");
            var z = Console.ReadLine();
            var isValidYears = double.TryParse(z, out double years);

            if (isValidAmount && isValidRate && isValidYears)
            {
                var totalValue = amount * Math.Pow((1 + interestRate / (100 * 12)), years * 12);
                Console.WriteLine($"Accumulated value is :{totalValue:C}"); ;
            }
            else
            {
                Console.WriteLine("Please enter valid details");
            }
        }

        private static void Exercise223Driving()
        {
            Console.WriteLine("Enter the driving distance");
            var d = Console.ReadLine();
            var isValidDistance = decimal.TryParse(d, out decimal distance);

            Console.WriteLine("Enter miles per gallon");
            var m = Console.ReadLine();
            var isValidMpg = decimal.TryParse(m, out decimal mpg);

            Console.WriteLine("Enter price per gallon");
            var f = Console.ReadLine();
            var isValidPrice = decimal.TryParse(f, out decimal ppg);
            if (isValidDistance&&isValidMpg&&isValidPrice)
            {
                decimal costOfDriving = (distance / mpg) * ppg;
                    Console.WriteLine($"The cost of driving is: {costOfDriving:C}");
            }
            else
            {
                Console.WriteLine("Please enter correct details");
            }
            
        }

        private static void Exercise22VolumeCylinder()
        {
            Console.WriteLine("Please enter the radius");
            var radius = Console.ReadLine();
            var isValidRadius = double.TryParse(radius, out double rad);

            Console.WriteLine("Please enter the length");
            var length = Console.ReadLine();
            var isValidLength = double.TryParse(length, out double len);
            if(isValidRadius&&isValidLength)
            {
                double area = rad * rad * Math.PI;
                Console.WriteLine($"The area of the cylinder is {area}");


                double volume = area * len;
                Console.WriteLine($"The volume of the cylinder is {volume}");
            }
            else
            {
                Console.WriteLine("Please enter a valid length and radius");
            }
        
            

            

        }
    }
}
