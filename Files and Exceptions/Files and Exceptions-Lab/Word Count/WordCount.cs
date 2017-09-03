namespace Word_Count
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class WordCount
    {
        public static void Main(string[] args)
        {
            string txtFromWords = File.ReadAllText("words.txt");
            string[] listWords = txtFromWords.Split(' ');

            string txtFromInput = File.ReadAllText("text.txt");
            char[] splitOptions = new char[6] { ' ', '?', '.', '-', '!', ',' };
            string[] listInput = txtFromInput.Split(splitOptions, StringSplitOptions.RemoveEmptyEntries);
            
            SortedDictionary<string, int> dictionary = new SortedDictionary<string,int>();

            for (int i = 0; i < listInput.Length; i++)
            {
                
                for (int j = 0; j < listWords.Length; j++)
                {
                    if (listInput[i].ToLower() == listWords[j])
                    {
                        if (!dictionary.ContainsKey(listInput[i].ToLower()))
                        {
                            dictionary[listInput[i].ToLower()] = 1;
                        }
                        else
                        {
                            dictionary[listInput[i].ToLower()] += 1;
                        }
                    }
                }
            }

            if (File.Exists("Output.txt"))
            {
                File.WriteAllText("Output.txt", string.Empty);
            }
            
            foreach (var item in dictionary.OrderByDescending(x => x.Value))
            {
                Console.WriteLine("{0} - {1}", item.Key, item.Value);
                string lineResult = item.Key + " - " + item.Value + Environment.NewLine;
                File.AppendAllText("Output.txt", lineResult);
            }
        }
    }
}
