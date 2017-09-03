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
            //add racer to list
            var racers = Console.ReadLine().Split(' ').ToArray();

            List<Racer> racerList = new List<Racer>();

            //adding racers to list and create racers objects;
            foreach (var str in racers)
            {
                Racer currentRacer = new Racer();
                currentRacer.Name = str;
                currentRacer.StopPosition = -1;
                racerList.Add(currentRacer);
            }

            //add fuel zone to list
            var fuelList = Console.ReadLine().Split(' ').ToList();

            //add check points to list
            var checkList = Console.ReadLine().Split(' ').ToList();

            //calculate the fuel for the racers and position to stop;
            foreach (var racer in racerList)
            {
                double fuel = Convert.ToInt32(racer.Name[0]);
               
                for (int i = 0; i < fuelList.Count; i++)
                {
                    var zonePos = i;

                    if ( checkList.Contains(zonePos.ToString()))
                    {
                        fuel += double.Parse(fuelList[zonePos]);
                        racer.Fuel = fuel;
                        
                        if (racer.Fuel == 0 || racer.Fuel < 0)
                        {
                            racer.StopPosition = zonePos;
                            break;
                        }
                    }
                    else
                    {
                        fuel -= double.Parse(fuelList[zonePos]);
                        racer.Fuel = fuel;
                       
                        if (racer.Fuel == 0 || racer.Fuel < 0)
                        {
                            racer.StopPosition = zonePos;
                            break;
                        }
                    }
                }
            }

            //printing the result;
            foreach (var racer in racerList)
            {
                if (racer.StopPosition < 0)
                {
                    Console.WriteLine("{0} - fuel left {1:F2}", racer.Name, racer.Fuel);
                }
                else if (racer.StopPosition >= 0)
                {
                    Console.WriteLine("{0} - reached {1}", racer.Name, racer.StopPosition);
                }
            }
        }
    }
}
