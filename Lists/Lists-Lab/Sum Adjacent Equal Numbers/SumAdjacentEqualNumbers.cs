namespace Sum_Adjacent_Equal_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SumAdjacentEqualNumbers
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> summedList = new List<double>(); 

            summedList = SumEqualNumbers(list);

            foreach (var number in summedList)
            {
                Console.WriteLine("{0}", number);
            }
        }

        public static List<double> SumEqualNumbers(List<double> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                while (i < list.Count - 1)
                {
                    if (list[i] == list[i + 1])
                    {
                        list[i] = list[i] + list[i + 1];
                        list.RemoveAt(i + 1);
                        if (i > 0)
                        {
                            i--;
                        }
                    }
                    else
                    {
                        i++;
                    }
                }
            }

            return list;
        }
    }
}
