using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForMultiplication();

            CountWithWhileLoop();
            //CountWithDoWhile();
        }

        private static void CountWithDoWhile()
        {
            var k = 0;
            do
            {
                Console.WriteLine(k);
                k++;
            } while (k <= 100);
        }

        private static void CountWithWhileLoop()
        {
            var i = 1;

            while(i <= 100)
            {
                Console.WriteLine(i);
                if (i % 2 == 0) break;
                i++;
            }
        }

        private static void ForMultiplication()
        {
            for (int i = 1; i <= 10; i++)
            {

                for (int j = 0; j <= 10; j++)
                {
                    var product = i * j;
                    if (product % 2 == 1)
                        Console.Write($"{i} X {j} = {product}\t ");
                    Console.WriteLine();
                }
            }
        }
    }
}
