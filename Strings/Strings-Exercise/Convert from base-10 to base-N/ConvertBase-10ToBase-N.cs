namespace Convert_from_base_10_to_base_N
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class ConvertBase10ToBaseN
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToArray();

            var baseNumber = line[0];
            var number = line[1];

            var result = new StringBuilder();

            while (number > 0)
            {
                BigInteger currentNumber = number / baseNumber;
                BigInteger leftNumber = number % baseNumber;
                result.Append(leftNumber.ToString());
                number = currentNumber;
            }

            Console.WriteLine("{0}", new string(result.ToString().Reverse().ToArray()));
        }
    }
}
