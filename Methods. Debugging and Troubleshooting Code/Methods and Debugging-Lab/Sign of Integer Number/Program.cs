using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sign_of_Integer_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            PrintSign(n);

        }

        public static void PrintSign(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("The number {0} is zero.", number);
            }
            else if (number > 0)
            {
                Console.WriteLine("The number {0} is positive.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is negative.", number);
            }
        }
    }
}
