namespace Reverse_String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ReverseString
    {
        public static void Main(string[] args)
        {
            var inputString = Console.ReadLine();

            string outputString = new string (inputString.Reverse().ToArray());

            Console.WriteLine(outputString);
        }
    }
}
