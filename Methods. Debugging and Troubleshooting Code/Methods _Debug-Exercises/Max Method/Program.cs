using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            var number3 = int.Parse(Console.ReadLine());

            int bigestNumber = GetMax(number1, number2);

            if (bigestNumber >= number3)
            {
                Console.WriteLine(bigestNumber);
            }
            else
            {
                Console.WriteLine(number3);
            }

        }

        public static int GetMax(int number1, int number2)
        {
            if (number1 >= number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

    }
}
