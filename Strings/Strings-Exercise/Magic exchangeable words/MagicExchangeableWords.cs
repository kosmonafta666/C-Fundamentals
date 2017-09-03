namespace Magic_exchangeable_words
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MagicExchangeableWords
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').ToArray();

            var str1 = input[0];
            var str2 = input[1];

            HashSet<char> listStr1 = new HashSet<char>();
            HashSet<char> listStr2 = new HashSet<char>();

            foreach (var chars in str1)
            {
                listStr1.Add(chars);
            }

            foreach (var chars in str2)
            {
                listStr2.Add(chars);
            }

          
            if (listStr1.Count != listStr2.Count)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }
        }
    }
}
