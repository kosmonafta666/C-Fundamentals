using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').ToArray();

            var reversedArray = ReverseArray(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", reversedArray[i]);
            }

            Console.WriteLine();
        }

        private static string[] ReverseArray(string[] arr)
        {

            string[] reverseArr = new string[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                reverseArr[i] = arr[arr.Length - 1 - i];
            }

            return reverseArr;
        }
    }
}
