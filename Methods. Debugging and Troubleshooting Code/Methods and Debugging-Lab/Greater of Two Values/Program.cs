using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {

            var type = Console.ReadLine();

            if (type == "int")
            {
                var first = int.Parse(Console.ReadLine());
                var second = int.Parse(Console.ReadLine());

                int result = GetMax(first, second);

                Console.WriteLine(result);
            }
            else if (type == "char")
            {
                var first = char.Parse(Console.ReadLine());
                var second = char.Parse(Console.ReadLine());

                char result = GetMax(first, second);

                Console.WriteLine(result);
            }
            else if (type == "string")
            {
                var first = Console.ReadLine();
                var second = Console.ReadLine();

                string result = GetMax(first, second);

                Console.WriteLine(result);
            }

        }

        public static int GetMax(int first, int second)
        {
            if (first >= second)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static char GetMax(char first, char second)
        {
            int firstChar = first - 'a';
            int secondChar = second - 'a';

            if (firstChar >= secondChar)
            {
                return first;
            }
            else
            {
                return second;
            }
        }

        public static string GetMax(string first, string second)
        {
            int compareStrintgs = first.CompareTo(second);

            if (compareStrintgs >= 0) 
            {
                return first;
            }
            else
            {
                return second;
            }
        }
    }
}
