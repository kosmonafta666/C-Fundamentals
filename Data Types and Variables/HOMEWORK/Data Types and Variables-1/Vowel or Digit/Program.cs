using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowel_or_Digit
{
    class Program
    {
        static void Main(string[] args)
        {
            var symbol = Console.ReadLine();
            symbol = symbol.ToLower();
            string result = "";

            switch (symbol)
            {
                case "0": result = "digit"; break;
                case "1": result = "digit"; break;
                case "2": result = "digit"; break;
                case "3": result = "digit"; break;
                case "4": result = "digit"; break;
                case "5": result = "digit"; break;
                case "6": result = "digit"; break;
                case "7": result = "digit"; break;
                case "8": result = "digit"; break;
                case "9": result = "digit"; break;
                case "a": result = "vowel"; break;
                case "e": result = "vowel"; break;
                case "i": result = "vowel"; break;
                case "o": result = "vowel"; break;
                case "u": result = "vowel"; break;
                case "y": result = "vowel"; break;
                default: result = "other"; break;
            }

            Console.WriteLine(result);
        }
    }
}
