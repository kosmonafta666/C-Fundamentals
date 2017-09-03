namespace Count_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class CountNumber
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            CountNumbers(list);
        }

        public static void CountNumbers(List<int> list)
        {
            int[] countArr = new int[list.Max() + 1];

            foreach (var number in list)
            {
                countArr[number]++;

            }

            for (int i = 0; i < countArr.Length; i++)
            {
                if (countArr[i] > 0)
                {
                    Console.WriteLine("{0} -> {1}", i, countArr[i]);
                }
            }
        }
    }
}
