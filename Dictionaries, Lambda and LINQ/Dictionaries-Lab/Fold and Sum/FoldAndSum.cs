namespace Fold_and_Sum
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FoldAndSum
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int k = list.Count / 4;

            var leftRow = list.Take(k).Reverse().ToList();
            list.Reverse();
            var rightRow = list.Take(k).ToList();
            leftRow.AddRange(rightRow);
            list.Reverse();
            var middleRow = list.Skip(k).Take(2 * k).ToList();

            var sum = leftRow.Select((x, index) => x + middleRow[index]).ToList();
            Console.Write("{0} ", string.Join(" ", sum));
       }
    }
}

