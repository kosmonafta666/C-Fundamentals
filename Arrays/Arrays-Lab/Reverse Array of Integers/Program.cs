using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            int[] arrInt = new int[number];

            for (int i = 0; i < number; i++)
            {
                var currentInt = int.Parse(Console.ReadLine());
                arrInt[i] = currentInt;
            }

            ReverseIntArr(arrInt);

        }

        private static void ReverseIntArr(int[] arrInt)
        {
            int len = arrInt.Length;

            for (int i = len - 1; i >= 0; i--)
            {
                Console.WriteLine(arrInt[i]);
            }
        }
    }
}
