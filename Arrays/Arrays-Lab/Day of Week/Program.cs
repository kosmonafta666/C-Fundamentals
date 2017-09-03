using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            var dayIndex = int.Parse(Console.ReadLine());

            string dayOfWeek = DayOfWeek(dayIndex);

            Console.WriteLine(dayOfWeek);
        }

        private static string DayOfWeek(int dayIndex)
        {

            string[] day = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};

            if (dayIndex <= 0 || dayIndex > 7)
            {
                return "Invalid Day!";
            }
            else
            {
                return day[dayIndex - 1];
            }
        
        }
    }
}
