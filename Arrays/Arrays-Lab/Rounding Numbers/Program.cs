using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            int len = arr.Length;

            for (int i = 0; i < len; i++)
            {
                double roundNumber = Math.Round(arr[i], MidpointRounding.AwayFromZero);
                Console.WriteLine("{0} => {1}", arr[i], roundNumber);
            }

        }
    }
}
