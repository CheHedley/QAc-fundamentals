using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int k = CountLetters(null);
            }catch(ArgumentNullException e)
            {
                //Look at log4Net, Event Log
            }
        }



        public static void Reverse(int number)
        {
            Char[] digits = number.ToString().ToCharArray();
            var i = digits.Length - 1;
            StringBuilder sb = new StringBuilder();
            while (i >= 0)
            {
                sb.Append(digits[i]);
                i--;
            }

            var reversed = sb.ToString();
        }

        private static int CountLetters(String s) 
        {
            if (s == null && s == string.Empty)
            {
                throw new ArgumentNullException("Supplied argument is invalid");
            }
            else
            {
                var letterCount = 0;
                Char[] c = s.ToCharArray();
                int i = 0;
                while (i < c.Length)
                {
                    if (Char.IsLetter(c[i]))
                    {
                        letterCount++;
                    }
                    i++;
                }
                return letterCount;
            }


        }

    }
}
