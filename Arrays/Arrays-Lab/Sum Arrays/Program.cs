using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var arr2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SumArrays(arr1, arr2);

        }

        public static void SumArrays(int[] arr1, int[] arr2)
        {
            int sumIndex = 0;

            if (arr1.Length >= arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++) 
                {
                    sumIndex = arr1[i % arr1.Length] + arr2[i % arr2.Length];

                    Console.Write("{0} ", sumIndex);
                }

           }
            else if (arr2.Length >= arr1.Length)
            {
                for (int i = 0; i < arr2.Length; i++)
                {
                    sumIndex = arr1[i % arr1.Length] + arr2[i % arr2.Length];

                    Console.Write("{0} ", sumIndex);
                }

           }
        }
    }
}
