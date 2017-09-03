namespace Extract_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            string pattern = @"([\w.-]+)@[\w-]+(\.\w+)+";

            //only with this pattern;
            //string pattren1 = @"\b(?<!\-|\_|.)[A-Za-z]([\w.-]+)@[\w-]+(\.\w+)+\b";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string matchString = match.ToString();

                if ( !(matchString.StartsWith("-") 
                    || matchString.StartsWith(".") 
                    || matchString.StartsWith("_")
                    ||matchString.EndsWith("_" )
                    || matchString.EndsWith(".")
                    || matchString.EndsWith("-")) )
                {
                    Console.WriteLine(matchString);
                }
            }
        }
    }
}
