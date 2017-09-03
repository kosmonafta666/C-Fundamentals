﻿namespace Convert_from_base_N_to_base_10
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Numerics;

    public class ConvertBaseNToBase10
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').ToArray();

            var baseNumber = BigInteger.Parse(line[0]);
            var number = line[1];
            number = new string(number.Reverse().ToArray());
      
            var result = new BigInteger();

            for (int i = 0; i < number.Length; i++)
            {
                BigInteger currentDigit = (BigInteger)char.GetNumericValue(number[i]);
                result += currentDigit * BigInteger.Pow(baseNumber, i);
            }

            Console.WriteLine("{0}", result);
        }
    }
}
