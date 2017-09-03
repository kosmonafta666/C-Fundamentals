namespace Rage_Quit
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class RageQuit
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine().ToUpper();

            //pattern for extract patterns;
            string pattern = @".*?[0-9]+";

            //creating regex
            var regex = new Regex(pattern);

            //creating collection of matches;
            var matches = regex.Matches(input);

            //string builder for result;
            var result = new StringBuilder();

            foreach (Match match in matches)
            {
                var newMatch = match.ToString();

                //create counter for substrings;
                var counter = int.Parse(Regex.Match(newMatch, @"[0-9]+").Value);

                //creating substrings;
                newMatch = Regex.Replace(newMatch, @"[0-9]", "");

                //appending result;
                for (int i = 0; i < counter; i++)
                {
                    result.Append(newMatch);
                }

            }

            //creating array for unique symbols
            var unique = result.ToString().Distinct().ToArray();

            //printing result;
            Console.WriteLine("Unique symbols used: {0}", unique.Length);
            Console.WriteLine(result);
        }
    }
}