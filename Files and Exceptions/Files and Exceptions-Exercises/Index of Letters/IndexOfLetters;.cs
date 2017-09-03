namespace Index_of_Letters
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Diagnostics;

    public class IndexOfLetterts
    {
        public static void Main(string[] args)
        {
            string inputLetters = ReadFromFile("Input.txt");

            WriteOnFile(inputLetters);
        }

        public static string ReadFromFile(string path)
        {
            string result = File.ReadAllText(path);

            return result;
        }

        public static void WriteOnFile(string inputLetters)
        {
            if (File.Exists("Output.txt"))
            {
                File.Delete("Output.txt");
            }

            foreach (var letter in inputLetters)
            {
                int indexOfLetter = ((int)letter - 'a');
                Console.WriteLine("{0} -> {1}", letter, indexOfLetter);

                string result = letter + " -> " + indexOfLetter;
                File.AppendAllText("Output.txt", result + Environment.NewLine);
            }
        }
    }
}
