using System;
using System.Linq;

class MaxSequenceOfEqualElements
{
    static void Main()
    {
        var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        MaxSequence(arr);
    }

    private static void MaxSequence(int[] arr)
    {
        int counter = 1;
        int maxCounter = 1;
        int maxElement = arr[0];
        int element = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == element)
            {
                counter++;

                if (maxCounter < counter)
                {
                    maxCounter = counter;
                    maxElement = element;
                }
            }
            else
            {
                counter = 1;
                element = arr[i];
            }
        }
        
        for (int i = 1; i <= maxCounter; i++)
        {
            Console.Write("{0} ", maxElement);
        }

    }
}