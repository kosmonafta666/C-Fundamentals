using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double threshold = double.Parse(Console.ReadLine());
        double previousPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            //calculate the diffence between previous and current price;
            double difference = CalculateDiffernce(previousPrice, currentPrice);
            //returt wheter difference is bigger than threshold;
            bool isSignificantDifference = isDifferenceSignficant(difference, threshold);
            //return message for changes in the price;
            string message = GetMessage(currentPrice, previousPrice, difference, isSignificantDifference);
            
            Console.WriteLine(message);

            //current price became previous;
            previousPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double previousPrice, double difference, bool isSignificantDifference)
    {
        string message = "";

        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!isSignificantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
        }
        else if (isSignificantDifference && (difference < 0))
        {
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", previousPrice, currentPrice, difference * 100);
        }
           
        return message;
    }

    
    private static bool isDifferenceSignficant(double difference, double threshold)
    {
        if ( Math.Abs(difference) >= Math.Abs(threshold) )
        {
            return true;
        }

        return false;
    }

    private static double CalculateDiffernce(double previousPrice, double currentPrice)
    {

        return (currentPrice - previousPrice) / previousPrice;

    }
}
