namespace Append_Lists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ApendLists
    {
        public static void Main(string[] args)
        {
            var listString = Console.ReadLine().Split('|').ToList();

            var result = new List<string>();

            for (int i = listString.Count - 1; i >= 0; i--)
            {
                result.Add(string.Join(" ", listString[i].Split(new char[0] , StringSplitOptions.RemoveEmptyEntries)));
            }

            foreach (var num in result)
            {
              
                Console.Write("{0} ", num);
            }
        }
    }
}
