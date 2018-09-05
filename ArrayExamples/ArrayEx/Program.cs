using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayEx
{
    class Program
    {
        static void Main(string[] args)
        {

            //ShuffleArray();
            //SumAllElements();
            //SumAllOdd();
            //SumAllEven();
            //FindAverage();
            //DisplayInreverse();
            //ElementsDoubled();
            

            int[] k = {2,4,5,6,8,9,10,11,12};
            int total = SumAllElements(k); 
            var average = total / k.Length;
            Console.WriteLine($"The average value of the array is: {average}");
            double totalOdd = SumAllEven(true,k);
            Console.WriteLine(k.ToList());

            ShuffleElements(k);
            /*TASKS
          * shuffle array
          * sum the elements of the array
          * sum all the odd numbers
          * sum all the even numbers
          * find the average of the numbers in the array
          * display elements in reverse order
          * make a copy of the array in which each element is double the value of an element in the original
          */
            // declaring array when values are known
            //datatype[]  arrayname = {value1,value2,value3};
            // decalring array, datatype arrayname[] = new datatype[size of array]



        }

        private static void ShuffleElements(int[] k)
        {
            Random r = new Random();
            int[] shuffled = new int[k.Length];
            for (int i = 0; i < k.Length; i++)
            {
                int j = new Random().Next(0, k.Length);
                Console.WriteLine(j);
                shuffled[i] = k[j];
            }

        }

        private static void ElementsDoubled()
        {
            
        }

        private static void DisplayInreverse(int[] k)
        {
            int[] reversedArray = new int[k.Length];

            for (int i = k.Length - 1, j=0; i >= 0; i--, j++)
            {
                reversedArray[j] = k[i];
            }
        }

        private static void FindAverage()
        {
            throw new NotImplementedException();
        }

        private static double SumAllEven(bool isEven,int[] k)
        {
            var totalEven = 0;
            var totalOdd = 0;
            for (int i = 0; i < k.Length; i++)
            {
                if (k[i] % 2 == 0)
                {
                    totalEven += k[i];
                }
                else
                {
                    totalOdd += k[i];
                }
            }
            return isEven ? totalEven : totalOdd;
        }

        private static void SumAllOdd()
        {
            throw new NotImplementedException();
        }

        private static int SumAllElements(int[] k)
        {
            var total = 0;
            for(int i = 0; i < k.Length; i++)
            {
                total += k[i];
            }
            Console.WriteLine(total);
            return total;
        }

        private static void ShuffleArray()
        {

        }   


    }
}
