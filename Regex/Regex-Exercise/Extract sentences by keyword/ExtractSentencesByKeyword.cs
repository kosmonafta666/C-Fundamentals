namespace Extract_sentences_by_keyword
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ExtractSentencesByKeyword
    {
        public static void Main(string[] args)
        {
            var word = Console.ReadLine();
            var text = Console.ReadLine().Split(new char[]{'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);

            string pattern = @"\b" + word + @"\b";

            Regex regex = new Regex(pattern);

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }  
            }
        }
    }
}
