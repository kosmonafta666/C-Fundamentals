namespace Sino_The_Walker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;
    using System.Numerics;

    public class SinoTheWalker
    {
        public static void Main(string[] args)
        {
            //var for time;
            var time = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);
            //var for number of steps;
            ulong numberOfSteps = ulong.Parse(Console.ReadLine());
            //var for time for one step;
            ulong timeStep = ulong.Parse(Console.ReadLine());

            //var for total time;
            ulong secondsWalk = numberOfSteps * timeStep;

            //convert time to second
            ulong initialSeconds = (ulong)(time.Hour * 60 * 60) + (ulong)(time.Minute * 60) + (ulong)time.Second;
            //total second;
            ulong totalSeconds = (ulong)initialSeconds + (ulong)secondsWalk;

            //convert second, minutes and seconds;
            var seconds = totalSeconds % 60;
            var totalMinutes = totalSeconds / 60;
            var minutes = totalMinutes % 60;
            var totalHours = totalMinutes / 60;
            var hours = totalHours % 24;

            //var date = new DateTime()
            Console.WriteLine("Time Arrival: {0:00}:{1:00}:{2:00}", hours, minutes, seconds);
        }
    }
}
