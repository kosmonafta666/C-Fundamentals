namespace Advertisement_Message
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class AdvertisementMessage
    {
        public static void Main(string[] args)
        {
            string[] phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
            string[] events = new string[] {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
            string[] authors = new string[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};
            string[] towns = new string[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

            var numberOfMessages = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 1; i <= numberOfMessages; i++)
            {
                var rndPhrases = rnd.Next(0, phrases.Length);
                var rndEvents = rnd.Next(0, events.Length);
                var rndAuthors = rnd.Next(0, authors.Length);
                var rndTowns = rnd.Next(0, towns.Length);

                Console.WriteLine("{0} {1} {2} - {3}", phrases[rndPhrases], events[rndEvents], authors[rndAuthors], towns[rndTowns]);
            }
        }
    }
}
