using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Sequence_of_Increasing_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MaxSequenceIncrease(arr);
        }

        private static void MaxSequenceIncrease(int[] arr)
        {
            int counter = 1;
            int maxSequence = 0;
            string currNumbers = "";
            string maxNumbers = "";

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currNum = arr[i];
                int nextNum = arr[i + 1];

                if (currNum < nextNum)
                {
                    counter++;
                    currNumbers += currNum + " ";
                }
                else
                {
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        currNumbers += currNum + " ";
                        maxNumbers = currNumbers;
                    }
                    counter = 1;
                    currNumbers = "";
                }
            }

            if (maxSequence < counter)
            {
                currNumbers += arr[arr.Length - 1] + " ";
                maxNumbers = currNumbers;
            }

            Console.WriteLine(maxNumbers);
        }
    }
}
