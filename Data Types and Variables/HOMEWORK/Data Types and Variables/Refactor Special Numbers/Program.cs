using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0; 
            int number = 0; 
            bool flag = false;

            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (i > 0)
                {
                    sumOfDigits += i % 10;
                    i = i / 10;
                }

                flag = (sumOfDigits == 5) || (sumOfDigits == 7) || (sumOfDigits == 11);
                Console.WriteLine($"{number} -> {flag}");
                sumOfDigits = 0;
                i = number;
            }
         }
    }
}
