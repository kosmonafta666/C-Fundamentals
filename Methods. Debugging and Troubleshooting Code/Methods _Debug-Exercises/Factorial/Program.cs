using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger factoriel = Factoriel(number);

            Console.WriteLine(factoriel);
        }

        public static BigInteger Factoriel(int number)
        {
            BigInteger factoriel = 1;

            for (int i = 2; i <= number; i++)
            {
                factoriel *= i;
            }

            return factoriel;
        }
    }
}
