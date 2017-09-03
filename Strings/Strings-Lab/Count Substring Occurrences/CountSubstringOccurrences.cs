namespace Count_Substring_Occurrences
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountSubstringOccurrences
    {
        public static void Main(string[] args)
        {
            var inputString = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();

            var index = 0;
            var count = 0;

            while (true)
            {
                var found = inputString.IndexOf(pattern, index);

                if (found >= 0)
                {
                    count++;
                    index = found + 1;
                }
                else
                {
                    break;
                }
                
            }

            Console.WriteLine(count);
        }
    }
}
