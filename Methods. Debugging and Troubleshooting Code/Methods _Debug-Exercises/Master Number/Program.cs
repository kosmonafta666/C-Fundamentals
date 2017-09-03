using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());

            for (int i = 1; i <= range; i++)
            {
                bool sumOfDigits = SumOfDigits(i);
                bool containsEvenDigit = ContainsEvenDigit(i);
                bool isPalindrome = IsPalindrome(i);

                if (sumOfDigits && containsEvenDigit && isPalindrome)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public static bool SumOfDigits(int number)
        {
            bool flag = false;
            int sum = 0;

            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }

            if (sum % 7 == 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            
            return flag;
        }

        public static bool ContainsEvenDigit(int number)
        {
            bool flag = false;
            int digit = 0;
            int count = 0;

            while (number > 0)
            {
                digit = number % 10;

                if (digit % 2 == 0)
                {
                    count++;
                }

                number /= 10;
            }

            if (count > 0)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }

        public static bool IsPalindrome(int number)
        {
            bool flag = false;
            string numberStr = number.ToString();
            int len = numberStr.Length;
            int countPairs = 0;

            for (int i = 0; i < (len / 2); i++)
            {
                if (numberStr[i] == numberStr[(len - 1) - i])
                {
                    countPairs++;
                }

            }

            if (countPairs == (len / 2))
            {
                flag = true;
            }
            else
            {
                flag = false;
            }

            return flag;
        }
    }
}
