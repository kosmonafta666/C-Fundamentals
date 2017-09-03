namespace Line_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;

    public class LineNumbers
    {
        public static void Main(string[] args)
        {
            string[] lineFromFile = File.ReadAllLines("Input.txt");

            for (int i = 0; i < lineFromFile.Length; i++)
            {
                Console.WriteLine("{0}. {1}", (i + 1), lineFromFile[i]);

                if (File.Exists("Output.txt") && i == 0)
                {
                    File.WriteAllText("Output.txt", string.Empty);
                }

                using (StreamWriter file = File.AppendText("Output.txt"))
                {
                    string result = (i + 1) + ". " + lineFromFile[i];
                    file.WriteLine(result);
                }
            }
        }
    }
}
