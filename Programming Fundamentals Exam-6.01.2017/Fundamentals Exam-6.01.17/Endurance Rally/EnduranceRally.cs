namespace Endurance_Rally
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class EnduranceRally
    {
        public static void Main(string[] args)
        {
            //array for racers;
            var racers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //array for fuel zones;
            var fuelZones = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //array for checkpoints;
            var checkPoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            //var for stop index if fule is <= 0;
            var stopIndex = 0;
            for (int i = 0; i < racers.Length; i++)
            {
                //var for current racer;
                var racer = racers[i];
                //var for initial fuel by taking char value;
                double totalFuel = (int)racer[0];

                for (int fuelIndex = 0; fuelIndex < fuelZones.Length; fuelIndex++)
                {
                    
                    if (checkPoints.Contains(fuelIndex.ToString()))
                    {
                        totalFuel += double.Parse(fuelZones[fuelIndex]);
                        //Console.WriteLine(totalFuel);
                    }
                    else
                    {
                        totalFuel -= double.Parse(fuelZones[fuelIndex]);
                        //Console.WriteLine(totalFuel);
                    }

                    if (totalFuel <= 0)
                    {
                        stopIndex = fuelIndex;
                        Console.WriteLine("{0} - reached {1}", racer, stopIndex);
                        break;
                    }
                }//end of 2 for loop;

                if (totalFuel > 0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", racer, totalFuel);
                }
               
            }//enf of 1 for loop;

        }
    }
}
