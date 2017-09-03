namespace Hornet_Wings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetWings
    {
        public static void Main(string[] args)
        {
            var flaps = int.Parse(Console.ReadLine());
            var distanceFor1000 = double.Parse(Console.ReadLine());
            var endurance = int.Parse(Console.ReadLine());

            //distance for total flaps;
            var distance = (flaps / 1000) * distanceFor1000;
            //how many stop is nececery;
            var stopsToRest = flaps / endurance;
            //current time;
            var currentTime = (flaps / 100);
            //total time;
            var timeToTravel = currentTime + (stopsToRest * 5);

            Console.WriteLine("{0:F2} m.", distance);
           
            Console.WriteLine("{0} s.", timeToTravel);
        }
    }
}
