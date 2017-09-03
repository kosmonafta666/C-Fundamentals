namespace A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Diagnostics;

    public class MinerTask
    {
        public static void Main(string[] args)
        {
            string[] inputList = ReadFromFile("Input.txt");


        }

        public static string[] ReadFromFile(string path)
        {
            string[] inputLines = File.ReadAllLines(path);

            foreach (var line in inputLines)
            {
                Console.WriteLine("{0}", line);
            }

            Console.WriteLine();

            return inputLines;
        }
    }
}
