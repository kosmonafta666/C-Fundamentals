using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int fibonacciNumber = FibonacciNumber(number);

            Console.WriteLine(fibonacciNumber);
        }

        public static int FibonacciNumber(int number)
        {
            int previous = 1;
            int current = 1;
            int fibonacci = 1;

            for (int i = 1; i < number; i++)
            {
                fibonacci = current + previous;
                previous = current;
                current = fibonacci;
                
            }

            return fibonacci;
        }

       
    }
}
