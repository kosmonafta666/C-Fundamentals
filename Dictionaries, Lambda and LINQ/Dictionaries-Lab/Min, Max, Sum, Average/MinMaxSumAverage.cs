namespace Min__Max__Sum__Average
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MinMaxSumAverage
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<double> list = new List<double>();

            for (int i = 1; i <= n; i++)
            {
                var number = double.Parse(Console.ReadLine());
                list.Add(number);
            }

            MMSA(list);   
        }

        private static void MMSA(List<double> list)
        {
            double min = list.Min();
            double max = list.Max();
            double sum = list.Sum();
            double avg = list.Average();

            Console.WriteLine("Sum = {0}", sum);
            Console.WriteLine("Min = {0}", min);
            Console.WriteLine("Max = {0}", max);
            Console.WriteLine("Average = {0}", avg);
        }
    }
}
