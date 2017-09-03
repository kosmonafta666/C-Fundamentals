namespace Max_Sequence_of_Equal_Elements
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MaxSequenceOfEqualElements
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> maxSequence = MaxSequenceOfEqual(list);

            Console.WriteLine("{0}", string.Join(" ", maxSequence));
        }

        public static List<int> MaxSequenceOfEqual(List<int> list)
        {
            var currentSubSequent = new List<int>();
            var longestSubSquent = new List<int>();

            currentSubSequent.Add(list[0]); 

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] == currentSubSequent[0])
                {
                    currentSubSequent.Add(list[i]);
                }
                else
                {
                    if (currentSubSequent.Count > longestSubSquent.Count)
                    {
                        longestSubSquent = new List<int>();

                        for (int j = 0; j < currentSubSequent.Count; j++)
                        {
                            longestSubSquent.Add(currentSubSequent[j]);
                        }
                    }

                    currentSubSequent = new List<int>();
                    currentSubSequent.Add(list[i]);
                }
            }

            if (currentSubSequent.Count > longestSubSquent.Count)
            {
                longestSubSquent = new List<int>();

                for (int j = 0; j < currentSubSequent.Count; j++)
                {
                    longestSubSquent.Add(currentSubSequent[j]);
                }
            }

            return longestSubSquent;
        }
    }
}
