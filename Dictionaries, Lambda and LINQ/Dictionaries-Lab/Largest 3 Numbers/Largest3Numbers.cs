namespace Largest_3_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Largest3Numbers
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var result = list.OrderByDescending(x => x).Take(3).ToList();

            Console.WriteLine("{0}", string.Join(" ", result));
        }
    }
}
