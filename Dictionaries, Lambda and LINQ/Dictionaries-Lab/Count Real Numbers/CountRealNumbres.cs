namespace Count_Real_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CountRealNumbres
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            SortedDictionary<double, int> dictionary = CreateDictFromList(list);

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }

        private static SortedDictionary<double, int> CreateDictFromList(List<double> list)
        {
            SortedDictionary<double, int> sortedDict = new SortedDictionary<double,int>();

            foreach (var number in list)
            {
                if (sortedDict.ContainsKey(number))
                {
                    sortedDict[number]++;
                }
                else
                {
                    sortedDict[number] = 1;
                }
            }

            return sortedDict;
        }
    }
}
