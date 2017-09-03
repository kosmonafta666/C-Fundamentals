using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());

            ReverseDigits(number);
        }

        public static void ReverseDigits(double number)
        {

            string numberString = number.ToString();
            int len = numberString.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                Console.Write(numberString[i]);
            }

            Console.WriteLine();

        }
    }
}
