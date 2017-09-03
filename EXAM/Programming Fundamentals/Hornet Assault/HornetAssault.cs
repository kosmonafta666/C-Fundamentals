namespace Hornet_Assault
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetAssault
    {
        public static void Main(string[] args)
        {
            var beehives = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var hornets = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //var power of hornets;
            var hornetsPower = 0;
            //var for remainig bees;
            var beesCount = 0;

            //Calculating the hornets power;
            foreach (var number in hornets)
            {
                hornetsPower += number;
            }
            //List for alive bees;
            List<int> aliveBees = new List<int>();
            //List for alive horners;
            List<int> aliveHornet = new List<int>();

            //var for died hornets;
            var count = 0;

            for (int i = 0; i < beehives.Length; i++)
            {
                if (hornets.Count == 0)
                {
                    aliveBees.Add(beehives[i]);
                }
                else if (beehives[i] >= hornetsPower)
                {
                    beesCount = beehives[i] - hornetsPower;
                    //Console.WriteLine("aliveBees: {0}", beesCount);
                    if (count < hornets.Count)
                    {
                        hornetsPower = hornetsPower - hornets[count];
                        hornets.RemoveAt(count);
                        count++;
                        aliveBees.Add(beesCount);
                    }
                }

                //Console.WriteLine(beesCount);
            }


            if (aliveBees.Count >= 0 && aliveBees.Any(x => x > 0))
            {
                //Console.Write("bees:");
                foreach (var f in aliveBees)
                {
                    if (f > 0) 
                    {
                        Console.Write("{0} ", f);
                    }
                }
                
            }
            else if (hornets.Count > 0)
            {
                Console.Write("hornets: ");
                Console.WriteLine(string.Join(" ", hornets));
            }

        }
    }
}
