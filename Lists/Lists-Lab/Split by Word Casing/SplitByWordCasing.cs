namespace Split_by_Word_Casing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SplitByWordCasing
    {
        public static void Main(string[] args)
        {
            char[] splitOption = new char[14] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']'};
            var listWord = Console.ReadLine().Split(splitOption, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var upperCase = new List<string>();
            var mixedCase = new List<string>();

            for (int i = 0; i < listWord.Count; i++)
            {
                int processedWord = ProcessedWord(listWord[i]);

                if (processedWord == 1)
                {
                    upperCase.Add(listWord[i]);
                }
                else if (processedWord == 2)
                {
                    lowerCase.Add(listWord[i]);
                }
                else if (processedWord == 3)
                {
                    mixedCase.Add(listWord[i]);
                }
            }

            
            Console.Write("Lower-case: {0} " , string.Join(", ", lowerCase));
            Console.WriteLine();
            Console.Write("Mixed-case: {0} ", string.Join(", ", mixedCase));
            Console.WriteLine();
            Console.Write("Upper-case: {0} ", string.Join(", ", upperCase));
            Console.WriteLine();
        }

        public static int ProcessedWord(string word) 
        {
            int countUpper = 0;
            int countLower = 0;

            for (int i = 0; i < word.Length; i++)
            {
                char symbol = ((char)word[i]);
                
                if ( (symbol >= 65 && symbol <= 90) )
                {
                    countUpper++;
                }
                else if ((symbol >= 97 && symbol <= 122))
                {
                    countLower++;
                }
            }

            if (countUpper == word.Length)
            {
                return 1;
            }
            else if (countLower == word.Length)
            {
                return 2;
            }
            else 
            {
                return 3;
            }
        }
        
    }
}
