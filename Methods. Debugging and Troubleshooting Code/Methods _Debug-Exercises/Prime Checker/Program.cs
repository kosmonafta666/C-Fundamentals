using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = long.Parse(Console.ReadLine());

            bool isPrime = IsPrime(number);

            Console.WriteLine(isPrime);

        }
            

        public static bool IsPrime(long number)
        {
            bool isPrime = true;

            if (number <= 0)
            {
                isPrime = false;
            }
            else if (number == 1)
            {
                isPrime = false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }

            return isPrime;

        }

    }
}
