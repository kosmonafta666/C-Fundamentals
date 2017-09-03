namespace Text_Filter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TextFilter
    {
        public static void Main(string[] args)
        {
            char[] splitOption= new char[2] {',', ' '};
            var bannedWords = Console.ReadLine().Split(splitOption, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }            

            Console.WriteLine(text);
        }
    }
}
