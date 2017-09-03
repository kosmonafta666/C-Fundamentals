using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power = int.Parse(Console.ReadLine());

            double powerNumber = RaiseToPower(number, power);

            Console.WriteLine(powerNumber);
        }

        public static double RaiseToPower(double number, int power)
        {
            double result = 1;

            for (int i = 1; i <= power; i++)
            {
                result *= number; 
            }

            return result;
        }
    }
}
