namespace Bomb_Numbers
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
            var bombList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int sum = 0;

            BombedList(list, bombList);
            
            foreach (var number in list)
            {
                sum += number;
            }
            Console.WriteLine(sum);
        }

        private static void BombedList(List<int> list, List<int>bomb)
        {
            int bombNumber = bomb[0];
            int bombPower = bomb[1];

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == bombNumber)
                {
                    list.RemoveAt(i);

                    for (int rigth = 1; rigth <= bombPower; rigth++)
                    {
                        if (i >= list.Count)
                        {
                            break;
                        }

                        list.RemoveAt(i);
                    }

                    for (int left = i - 1; left >= i - bombPower; left--)
                    {
                        if (left < 0)
                        {
                            break; 
                        }

                        list.RemoveAt(left);
                    }

                    i = 0;
                }

                
            }       
        }
    }
}
