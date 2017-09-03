namespace Softuni_Coffee_Orders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Globalization;

    public class SoftuniCoffeeOrders
    {
        public static void Main(string[] args)
        {
            var countOrder = int.Parse(Console.ReadLine());

            //total price;
            decimal totalPrice = 0.0m;

            for (int i = 1; i <= countOrder; i++)
            {
                //initializing the input;
                var pricePerCapsule = decimal.Parse(Console.ReadLine());
                var orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                var countCapsules = decimal.Parse(Console.ReadLine());

                //get the year, month an number of days of the current month;
                var year = orderDate.Year;
                var month = orderDate.Month;
                var daysOfMonth = DateTime.DaysInMonth(year, month);
                
                //calcuating the price;
                decimal price = ((daysOfMonth * countCapsules) * pricePerCapsule);
                totalPrice += price;

                Console.WriteLine("The price for the coffee is: ${0:F2}", price);
            }//end of for loop;

            Console.WriteLine("Total: ${0:F2}", totalPrice);
        }
    }
}
