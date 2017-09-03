using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var k = int.Parse(Console.ReadLine());

            long[] sequence = LastKnumbers(n, k);

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", sequence[i]);
            }

            Console.WriteLine();
        }

        public static long[] LastKnumbers(int n, int k) 
        {
            long lastNumber = 1;
            long[] sequence = new long[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = (i - k); j < (i - 1); j++)
                {
                    if (j < 0)
                    {
                        continue;
                    }

                    lastNumber += sequence[j];
                }

                sequence[i] = lastNumber;
            }

            return sequence;
        }
    }
}
