namespace Sum_Reversed_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumReversedNumbers
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            for (int i = 0; i < list.Count; i++)
            {
                int reversedNumber = ReverseDigit(list[i]);
                sum += reversedNumber;
            }

            Console.WriteLine(sum);
        }

        public static int ReverseDigit(int number)
        {
            string stringNum = number.ToString();
            char[] reversedNum = new char [stringNum.Length];

            for (int i = (stringNum.Length - 1); i >= 0; i--)
            {
                reversedNum[(stringNum.Length - 1) - i] = stringNum[i];
            }

            string reversed = new string(reversedNum);
            
            return int.Parse(reversed);
        }

    }
}
