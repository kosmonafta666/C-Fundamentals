using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicode_Characters
{
    public class UnicodeCharacters
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                Console.Write("\\u{0:x4}" , (int)currentChar);
            }

            Console.WriteLine();
        }
    }
}
