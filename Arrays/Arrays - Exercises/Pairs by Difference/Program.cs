using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var difference = int.Parse(Console.ReadLine());

            PairsByDifference(arr, difference);
        }

        private static void PairsByDifference(int[] arr, int difference)
        {
            int counter = 0;
        
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                   if (Math.Abs(arr[i] - arr[j]) == difference)
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }
    }
}
