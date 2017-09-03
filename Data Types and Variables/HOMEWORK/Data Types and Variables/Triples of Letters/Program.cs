using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triples_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                char letterI = (char)('a' + (i- 1));
                for (int j = 1; j <= n; j++)
                {
                    char letterJ = (char)('a' + (j - 1));
                    for (int k = 1; k <= n; k++)
                    {
                        char letterK = (char)('a' + (k - 1));
                        Console.WriteLine("{0}{1}{2}", letterI, letterJ, letterK);
                    }
                }
             }
        }
    }
}

