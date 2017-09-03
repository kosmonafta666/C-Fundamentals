namespace Merge_Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class MergeFiles
    {
        public static void Main(string[] args)
        {
            var linesFromFile1 = File.ReadLines("FileOne.txt");
            var linesFromFile2 = File.ReadLines("FileTwo.txt");

            List<int> sortedLines = new List<int>();

            foreach (var line in linesFromFile1)
            {
                sortedLines.Add(int.Parse(line));
            }

            foreach (var line in linesFromFile2)
            {
                sortedLines.Add(int.Parse(line));
            }

            sortedLines.Sort();

            if (File.Exists("Output.txt"))
            {
                File.WriteAllText("Output.txt", string.Empty);
            }

            foreach (var number in sortedLines)
            {
                Console.WriteLine(number);

                File.AppendAllText("Output.txt", number.ToString() + Environment.NewLine);
            }
        }
    }
}
