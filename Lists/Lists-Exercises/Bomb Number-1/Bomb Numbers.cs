namespace Bomb_Number_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class BombNumbers
    {
        public static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int sum = 0;

            BombedList(list, bomb);

            //Console.WriteLine("{0}", string.Join(" ", list));
            foreach (var number in list)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }

        private static void BombedList(List<int> list, List<int> bomb)
        {
            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    int left = Math.Max(i - bombPower, 0);
                    int right = Math.Min(i + bombPower, list.Count - 1);
                    int range = right - left + 1;

                    list.RemoveRange(left, range);

                    i = 0;
                }
            }
        }
    }
}
