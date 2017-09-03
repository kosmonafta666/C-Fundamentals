namespace Odd_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class OddOccurrences
    {
        public static void Main(string[] args)
        {
            var words = Console.ReadLine().ToLower().Split(' ');

            var wordDictionary = CreateDictFromString(words);

            CountOddWords(wordDictionary);
        }

        public static Dictionary<string, int> CreateDictFromString(string[] words)
        {
            var wordCount = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (!wordCount.ContainsKey(word))
                {
                    wordCount[word] = 1;
                }
                else
                {
                    wordCount[word]++;
                }
            }

            return wordCount;
        }

        public static void CountOddWords(Dictionary<string, int> wordsDict) 
        {
            var result = new List<string>();

            foreach (var item in wordsDict)
            {
                if (item.Value % 2 != 0)
                {
                    result.Add(item.Key);
                }
            }

            Console.Write(string.Join(", ", result));
            Console.WriteLine();
        }
    }
}
