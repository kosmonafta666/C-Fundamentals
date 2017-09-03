using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] condense = CondenseArrToNumber(arr);

            Console.WriteLine(condense[0]);
        }

        public static int[] CondenseArrToNumber(int[] arr)
        {
            int len = arr.Length;
            int[] condense = new int[len];
            int[] num = arr;

            if (len == 1)
            {
                condense[0] = arr[0];
            }
            else
            {
                do
                {
                    for (int i = 0; i < len - 1; i++)
                    {
                        condense[i] = num[i] + num[i + 1];
                    }

                    num = condense;
                    len--;
                }
                while (len >= 0);
            }
            
            return condense;
        }
    }
}
