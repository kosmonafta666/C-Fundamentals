namespace Sort_Numbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SortNumbers
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            
            SortedList(list);

            Console.Write("{0}", string.Join(" <= ", list));

            Console.WriteLine();
            
        }

        public static void SortedList(List<double> list)
        {
            for (int i = list.Count - 1; i > 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        double temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp; 
                    }
                }
            }
        }
    }
}
