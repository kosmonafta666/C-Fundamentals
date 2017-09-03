namespace Charity_Marathon
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CharityMarathon
    {
        public static void Main(string[] args)
        {
            var maratonDay = int.Parse(Console.ReadLine());
            var numberOfRunners = int.Parse(Console.ReadLine());
            var averageLaps = int.Parse(Console.ReadLine());
            var lenghtOfTrack = int.Parse(Console.ReadLine());
            var capacityOfTrack = int.Parse(Console.ReadLine());
            var donatedMoney = double.Parse(Console.ReadLine());

            var totalRunners = 0.0;
            var capacityOfRunners = maratonDay * capacityOfTrack;

            if (capacityOfRunners >= numberOfRunners)
            {
                totalRunners = numberOfRunners;
            }
            else
            {
                totalRunners = capacityOfRunners;
            }
            
            var totalKm = (totalRunners * averageLaps * lenghtOfTrack) / 1000.00;

            Console.WriteLine("Money raised: {0:F2}", totalKm * donatedMoney);
        }
    }
}
