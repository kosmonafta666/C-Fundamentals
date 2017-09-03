using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extract_Middle_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            ReturnMiddleElements(arr);
        }

        private static void ReturnMiddleElements(int[] arr)
        {
            int len = arr.Length;

            if (len == 1)
            {
                Console.WriteLine("{{ {0} }}", arr[0]);
            }
            else if (len % 2 == 0)
            {
                int middle = len / 2;

                Console.WriteLine("{{ {0}, {1} }}", arr[middle - 1], arr[middle]);
            }
            else if (len % 2 != 0)
            {
                int middle = len / 2;

                Console.WriteLine("{{ {0}, {1}, {2} }}", arr[middle - 1], arr[middle], arr[middle + 1]);
            }

        }
    }
}
