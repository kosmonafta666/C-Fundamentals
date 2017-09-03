using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Numbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var squareList = new List<int>();
            squareList = SquareNumber(list, squareList);

            squareList.Sort();
            squareList.Reverse();

            Console.Write("{0}", string.Join(" ", squareList));

            Console.WriteLine();
        }

        private static List<int> SquareNumber(List<int> list, List<int>squareList)
        {
            for (int i = 0; i < list.Count; i++)
            {
                double sqr = Math.Sqrt(list[i]);

                if (  sqr == (int)sqr ) 
                {
                    squareList.Add(list[i]);
                }
            }

            return squareList;
        }
    }
}
