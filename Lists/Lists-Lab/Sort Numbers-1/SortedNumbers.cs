namespace Sort_Numbers_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortedNumbers
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            list.Sort();

            Console.WriteLine("{0}", string.Join(" <= ", list));
        }
    }
}
