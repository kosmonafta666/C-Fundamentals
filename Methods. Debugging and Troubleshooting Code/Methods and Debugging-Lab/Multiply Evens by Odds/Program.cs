using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = Math.Abs(int.Parse(Console.ReadLine()));

            int multyplyOfEvensAndOdds = MultiplyOfEvensAndOdds(number);

            Console.WriteLine(multyplyOfEvensAndOdds);

        }

        public static int SumOfEvenDigit(int number)
        {
            int sum = 0;

            while (number > 0) 
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        public static int SumOfOddDigit(int number)
        {
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

                number /= 10;
            }

            return sum;
        }

        public static int MultiplyOfEvensAndOdds(int number)
        {
            int sumOfEvens = SumOfEvenDigit(number);
            int sumOfOdds = SumOfOddDigit(number);
            int multiplyDigits = sumOfEvens * sumOfOdds;

            return multiplyDigits;
        }
    }
}
