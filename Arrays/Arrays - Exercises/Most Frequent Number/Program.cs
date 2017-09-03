using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            MostFrequentNumber(arr);
        }

        private static void MostFrequentNumber(int[] arr)
        {
            int len = arr.Length;
            int counter = 0;
            int maxCounter = 0;
            int maXFrequent = 0;
            int currIndex = 0;

            for (int i = 0; i < len; i++)
            {
                currIndex = arr[i];

                for (int j = 0; j < len; j++)
                {
                    if (currIndex == arr[j])
                    {
                        counter++;

                        if (counter > maxCounter)
                        {
                            maxCounter = counter;
                            maXFrequent = currIndex;
                        }
                    }
                    else
                    {
                        counter = 0;
                    }
                }
            }

                Console.WriteLine("{0} ", maXFrequent);
        }
    }
}
