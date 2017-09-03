namespace ShortWordsSorted
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShortWordsSorted
    {
        public static void Main(string[] args)
        {
            char[] splitOption = new char[15] {' ', '.', ',', ':', ',', '(', ')', '[', ']', '"', '\'', '\\', '/', '!', '?'};

            var list = Console.ReadLine().ToLower().Split(splitOption, StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> result = list.Where(x => x.Length < 5).OrderBy(x => x).Distinct().ToList();

            Console.WriteLine("{0}", string.Join(", ", result));

            Console.WriteLine();
        }
    }
}
