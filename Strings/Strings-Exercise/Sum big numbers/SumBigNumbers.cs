using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_big_numbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            var number1 = Console.ReadLine().TrimStart('0');
            var number2 = Console.ReadLine().TrimStart('0');

            if (number1.Length > number2.Length)
            {
                number2 = number2.PadLeft(number1.Length, '0');
            }
            else if (number2.Length > number1.Length)
            {
                number1 =number1.PadLeft(number2.Length, '0');
            }

            StringBuilder result = new StringBuilder();

            int addition = 0;
            int remainder = 0;

            for (int i = number1.Length - 1; i >= 0; i--)
            {
                var num1 = char.GetNumericValue(number1[i]);
                var num2 = char.GetNumericValue(number2[i]);
                
                num1 += addition;
                addition = 0;

                if (num1 + num2 < 10)
                {
                    result.Append(num1 + num2);
                }
                else
                {
                    remainder = (int)(num1 + num2) % 10;
                    addition = (int)(num1 + num2) / 10;
                    result.Append(remainder);
                }

                if ((i == 0) && addition != 0)
                {
                    result.Append(addition);
                }
            }

            var resultStr = new string(result.ToString().Reverse().ToArray());

            Console.WriteLine(resultStr);
        }
    }
}
