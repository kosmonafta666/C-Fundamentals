namespace Odd_Lines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class OddLines
    {
        public static void Main(string[] args)
        {
            string[] lineFromFile = File.ReadAllLines("Input.txt");
            //List<string> result = new List<string>();

            for (int i = 0; i < lineFromFile.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(lineFromFile[i]);
                    //result.Add(lineFromFile[i]);

                    if (File.Exists("Result.txt") && i == 0)
                    {
                        File.WriteAllText("Result.txt", string.Empty);
                    }

                    File.AppendAllText("Result.txt", lineFromFile[i] + Environment.NewLine);
                }
            }

            //File.WriteAllLines("Result.txt", result);
        }
    }
}
