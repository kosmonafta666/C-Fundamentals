namespace Replace_a_tag
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class ReplaceTag
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            while (input != "end")
            {
                var regex = new Regex(@"<a.*?href.*?=(.*)>(.*?)<\/a>");

                var result = regex.Replace(input, @"[URL href=$1]$2[/URL]");

                Console.WriteLine(result);

                input = Console.ReadLine();
            }
        }
    }
}
