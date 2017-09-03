namespace Most_Frequent_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Diagnostics;

    public class MostFrequentNumber
    {
        public static void Main(string[] args)
        {
            List<int> lineSequence = ReadLineFromFile("Input.txt");

            int[] arr = new int[lineSequence.Count + 1];

            foreach (var number in lineSequence)
            {
                arr[number]++;
            }

            var frequencyOfNumber = arr.Max();
            var frequentNumber = 0;

            for (int i = 0; i < lineSequence.Count; i++) 
            {
                if (arr[lineSequence[i]] == frequencyOfNumber)
                {
                    frequentNumber = lineSequence[i];
                    break;
                }
            }

            WriteOnFile(frequentNumber, frequencyOfNumber);

        }

        public static List<int> ReadLineFromFile(string nameOfFile)
        {
            List<int> numberSequence = new List<int>();

            string[] lines = File.ReadAllLines(nameOfFile);

            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i].Split(' ');

                for (int j = 0; j < line.Length; j++)
                {
                    numberSequence.Add(int.Parse(line[j]));
                }
            }

            foreach (var number in numberSequence)
            {
                Console.Write("{0} ", number);
            }

            Console.WriteLine();

            return numberSequence;
        }

        public static void WriteOnFile(int frequentNumber, int frequencyOfNumber)
        {
            Console.WriteLine("The number {0} is the most frequent (occurs {1} times)", frequentNumber, frequencyOfNumber);

            if (File.Exists("Output.txt"))
            {
                File.WriteAllText("Output.txt", string.Empty);
            }
            string[] result = new string[1] {"The number " + frequentNumber + " is the most frequent (occurs " + frequencyOfNumber + " times)"};
            File.AppendAllLines("Output.txt", result);
        }
    }
}
