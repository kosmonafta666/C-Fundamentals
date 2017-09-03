namespace Palindromes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Palindromes
    {
        public static void Main(string[] args)
        {
            char[] splitOption = new char[5] { ' ', ',', '!', '?', '.' };
            var text = Console.ReadLine().Split(splitOption, StringSplitOptions.RemoveEmptyEntries);

            List<string> palindromes = new List<string>();

            for (int i = 0; i < text.Length; i++)
            {
                bool isPalindrome = IsPalindrome(text[i]);

                if (isPalindrome)
                {
                    palindromes.Add(text[i]);
                }
            }

                Console.WriteLine(string.Join(", ", palindromes.Distinct().OrderBy(x => x)));  
        }

        public static bool IsPalindrome(string word)
        {
            int rightIndex = word.Length - 1;
            int leftIndex = 0;
            while (rightIndex >= leftIndex)
            {
                if (word[rightIndex] != word[leftIndex])
                {
                    return false;
                }
                rightIndex--;
                leftIndex++;
            }
            return true;
        }
    }
}
