using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {

            var number = int.Parse(Console.ReadLine());

            BigInteger factoriel = Factoriel(number);
            BigInteger countZeroes = FactorielTrailingZeroes(factoriel);

            Console.WriteLine(countZeroes);

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

        public static BigInteger FactorielTrailingZeroes(BigInteger factoriel)
        {
            BigInteger countZeroes = 0;

            while (factoriel % 10 == 0)
            {
                factoriel /= 10;
                countZeroes++;
            }

            return countZeroes;

        }
    }
}
