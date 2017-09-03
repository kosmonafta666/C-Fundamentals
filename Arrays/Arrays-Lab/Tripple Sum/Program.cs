using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tripple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            var counter = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int b = i + 1; b < arr.Length; b++)
                {
                    for (int c = 0; c < arr.Length; c++)
                    {
                        if (arr[i] + arr[b] == arr[c])
                        {
                            Console.WriteLine(arr[i] + " + " + arr[b] + " == " + arr[c]);
                            counter++;
                            break;
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }

        }
    }
}
