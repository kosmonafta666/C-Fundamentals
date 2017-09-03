namespace Day_of_Week
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class DayOfWeek
    {
        public static void Main(string[] args)
        {
            var dateInput = Console.ReadLine();

            DateTime date = DateTime.ParseExact(dateInput, "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine("{0}", date.DayOfWeek);
        }
    }
}
