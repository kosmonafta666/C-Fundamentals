namespace Big_Factorial
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class BigFactorial
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            if (number == 0 || number == 1)
            {
                factorial = 1;
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    factorial *= i;
                }
            }

            Console.WriteLine(factorial);
        }
    }
}
