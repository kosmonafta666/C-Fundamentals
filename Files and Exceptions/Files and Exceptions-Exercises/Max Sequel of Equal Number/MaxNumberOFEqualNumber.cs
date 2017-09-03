namespace Max_Sequel_of_Equal_Number
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Diagnostics;

    public class MaxNumberOFEqualNumber
    {
        public static void Main(string[] args)
        {
            List<int> inputList = ReadFromFile("Input.txt");

            int count = 1;
            int maxCount = 1;
            int maxNumber = 0;

            for (int i = 0; i < inputList.Count - 1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    count++;
                }
                else
                {
                    if (count > maxCount)
                    {
                        maxCount = count;
                        maxNumber = inputList[i];
                    }

                    count = 1;
                }
            }

            WriteOnFile(maxCount, maxNumber);
        }

        

        public static List<int> ReadFromFile(string path)
        {
            List<int> inputList = new List<int>();
            var lines = File.ReadAllLines(path);

            for (int i = 0; i < lines.Length; i++)
            {
                inputList = lines[i].Split(' ').Select(int.Parse).ToList();
            }

            foreach (var number in inputList)
            {
                Console.Write("{0} ", number);

            }

            Console.WriteLine();

            return inputList;
        }

        public static void WriteOnFile(int maxCount, int maxNumber)
        {
            List<string> outputList = new List<string>();

            for (int i = 1; i <= maxCount; i++)
            {
                outputList.Add(maxNumber.ToString());
            }

            string result = string.Join(" ", outputList);

            if (File.Exists("Output.txt"))
            {
                File.WriteAllText("Output.txt", string.Empty);
            }

            File.AppendAllText("Output.txt", result);

            Console.WriteLine(result);
        }
    }
}
