namespace Count_Work_Days
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class CountWorkDays
    {
        public static void Main(string[] args)
        {
            var startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            int workingDays = 0;

            var year = 2016;
            List<DateTime> holidays = new List<DateTime>();

            holidays.Add(new DateTime(year, 1, 1));
            holidays.Add(new DateTime(year, 3, 3));
            holidays.Add(new DateTime(year, 5, 1));
            holidays.Add(new DateTime(year, 5, 6));
            holidays.Add(new DateTime(year, 5, 24));
            holidays.Add(new DateTime(year, 9, 6));
            holidays.Add(new DateTime(year, 9, 22));
            holidays.Add(new DateTime(year, 11, 1));
            holidays.Add(new DateTime(year, 12, 24));
            holidays.Add(new DateTime(year, 12, 25));
            holidays.Add(new DateTime(year, 12, 26));

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                var checkDate = new DateTime(2016, i.Month, i.Day);
                var day = i.DayOfWeek.ToString();
                
                if (!(holidays.Contains(checkDate) || day == "Saturday" || day == "Sunday"))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}