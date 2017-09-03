namespace Sino_The_Walker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class SinoTheWalker
    {
        public static void Main(string[] args)
        {
            DateTime startTime = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            var steps = uint.Parse(Console.ReadLine()) % 86400;
            var stepTime = uint.Parse(Console.ReadLine()) % 86400;
        
            double timeForWalk = steps * stepTime;

            startTime = startTime.AddSeconds(timeForWalk);

            Console.WriteLine("Time Arrival: {0:HH:mm:ss}", startTime);
        }
    }
}
