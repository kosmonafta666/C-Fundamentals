namespace Sweet_Dessert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class SweetDessert
    {
        public static void Main(string[] args)
        {
            var cash = double.Parse(Console.ReadLine());
            var guestNumber = int.Parse(Console.ReadLine());
            var bananaPrice = double.Parse(Console.ReadLine());
            var eggPrice = double.Parse(Console.ReadLine());
            var cherryPrice = double.Parse(Console.ReadLine());

            //how many pack of six need to cook
            var numberOfSix = 0.0;

            //initializing how many pacc of six is needed;
            if (guestNumber % 6 != 0)
            {
                numberOfSix = (guestNumber / 6) + 1;
            }
            else if (numberOfSix % 6 == 0)
            {
                numberOfSix = guestNumber / 6;
            }

            //var for money needed for one six;
            var priceForSix = (2 * bananaPrice) + (4 * eggPrice) + (0.2 * cherryPrice);

            //var for money needed for all six of pack;
            double totalMoney = numberOfSix * priceForSix;

            //check if money is enougn and printed the result;
            if (totalMoney <= cash)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:F2}lv.", totalMoney);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:F2}lv more.", Math.Abs(totalMoney - cash));
            }
        }
    }
}
