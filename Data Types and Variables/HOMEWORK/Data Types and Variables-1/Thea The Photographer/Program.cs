using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            var amountPictures = long.Parse(Console.ReadLine());
            var filterTime = long.Parse(Console.ReadLine());
            var filterFactor = long.Parse(Console.ReadLine());
            var uploadTime = long.Parse(Console.ReadLine());

            long totalFilterTime = amountPictures * filterTime;
            var goodPictures = (long)Math.Ceiling( (double)(amountPictures * filterFactor) / 100 );
            long totalUploadTime = goodPictures * uploadTime;

            long totalTime = totalFilterTime + totalUploadTime;
            /*
            int days = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;

            if (totalTime < 60)
            {
                days = 0;
                hours = 0;
                minutes = 0;
                seconds = totalTime;
            }
            else if (totalTime < 3600)
            {
                days = 0;
                hours = 0;
                minutes = totalTime / 60;
                seconds = totalTime % 60;
            }
            else if (totalTime < 86400)
            {
                days = 0;
                hours = totalTime / 3600;
                int remainder = totalTime % 3600; 
                minutes = remainder / 60;
                seconds = remainder % 60;
            }
            else if (totalTime >= 86400)
            {
                days = totalTime / 86400;
                int remainder = totalTime % 86400;
                hours = remainder / 3600;
                int remainder1 = remainder % 3600;
                minutes = remainder1 / 60;
                seconds = remainder1 % 60;
            }
            */
            
            TimeSpan time = TimeSpan.FromSeconds(totalTime);
            long days = time.Days;
            long hours = time.Hours;
            long minutes = time.Minutes;
            long seconds = time.Seconds;
            

            Console.WriteLine("{0}:{1:00}:{2:00}:{3:00}", days, hours, minutes, seconds);
        }
    }
}
