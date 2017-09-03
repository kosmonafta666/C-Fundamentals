namespace Remove_Negatives_and_Reverse
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class RemoveNeagativeAndReverse
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> reverseList = RemoveAndReverseNegative(list);

            if (reverseList.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                foreach (var number in reverseList)
                {
                    Console.Write("{0} ", number);
                }
            }

            Console.WriteLine();
        }

        private static List<int> RemoveAndReverseNegative(List<int> list)
        {
            var reverseList = new List<int>();

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] > 0)
                {
                    reverseList.Add(list[i]);
                    continue;
                }

                if (list[i] < 0)
                {
                    list.Remove(list[i]);
                }
            }

            return reverseList;
        }
    }
}
