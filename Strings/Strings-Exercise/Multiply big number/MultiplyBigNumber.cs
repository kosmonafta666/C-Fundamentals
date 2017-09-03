namespace Multiply_big_number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MultiplyBigNumber
    {
        public static void Main(string[] args)
        {
            var firstNumber = Console.ReadLine().TrimStart('0');
            var secondNumber = char.Parse(Console.ReadLine());

            if (firstNumber == "0" || secondNumber == '0' || firstNumber == "")
            {
                Console.WriteLine(0);
                return;
            }

            StringBuilder result = new StringBuilder();

            int addition = 0;
            int remainder = 0;
            var product = 0;

            for (int i = firstNumber.Length - 1; i >= 0; i--)
            {
                var num1 = char.GetNumericValue(firstNumber[i]);
                var num2 = char.GetNumericValue(secondNumber);
                product = (int)(num1 * num2) + addition;
                remainder = product % 10;
                addition = product / 10;
                
                result.Append(remainder);

                if (i == 0 && addition != 0) 
                {
                    result.Append(addition);
                }
            }

            var resultStr = new string(result.ToString().Reverse().ToArray());

            Console.WriteLine(resultStr);
        }
    }
}
