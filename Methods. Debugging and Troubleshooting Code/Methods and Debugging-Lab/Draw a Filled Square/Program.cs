using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draw_a_Filled_Square
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            PrintFilledSquare(number);
        }

        public static void PrintHeaderRow(int number)
        {
            string row = new string('-', (2 * number));
            Console.WriteLine(row);
        }

        public static void PrintMiddleRow(int number) 
        {
            int middleSlash = ( (2 * number) - 2 ) / 2;

            Console.Write("-");

            for (int i = 1; i <= middleSlash; i++) 
            {

                Console.Write("\\/");
            }

            Console.Write("-");
        }

        public static void PrintFilledSquare(int number)
        {
            PrintHeaderRow(number);

            for (int i = 1; i <= (number - 2); i++)
            {
                PrintMiddleRow(number);
                Console.WriteLine();
            }
                
            PrintHeaderRow(number);
        }
    }
}
