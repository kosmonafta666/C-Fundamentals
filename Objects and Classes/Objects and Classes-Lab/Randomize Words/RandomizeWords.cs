namespace Randomize_Words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RandomizeWords
    {
        public static void Main(string[] args)
        {
            var text = Console.ReadLine().Split(' ').ToArray();
            Random rnd = new Random();
            
            for (int i = 0; i < text.Length; i++)
            {
                var currentWord = text[i];
                var randomIndex = rnd.Next(0, text.Length);
                var tempWord = text[randomIndex];
                text[i] = tempWord;
                text[randomIndex] = currentWord;
            }

            foreach (var word in text)
            {
                Console.WriteLine(word);
            }
        }
    }
}
