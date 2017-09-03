namespace Hands_of_Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HandsOfCards
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine();

            var cards = new Dictionary<string, HashSet<int> >();
            var cardPowers = GetPowerOfCard();
            var cardTypes = getTypeOfCard();


            while (line != "JOKER")
            {
                
                var tokens = line.Split(':');

                var name = tokens[0];
                var playerCards = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0, card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);

                    int sum = cardPowers[cardPower] * cardTypes[cardType];

                    if (!cards.ContainsKey(name))
                    {
                        cards[name] = new HashSet<int>() {sum};
                    }
                    else
                    {
                        cards[name].Add(sum);
                    }
                }

                line = Console.ReadLine();
            }

            foreach (var pair in cards)
            {
                
                var name = pair.Key;
                var cardValue = pair.Value.Sum();

                Console.WriteLine("{0}: {1}", name, cardValue);
            }

          }

      

        public static Dictionary<string, int> GetPowerOfCard()
        {
            var powerCard = new Dictionary<string, int>();

            for (int i = 2; i <= 10; i++) 
            {
                powerCard[i.ToString()] = i;
            }

            powerCard["J"] = 11;
            powerCard["Q"] = 12;
            powerCard["K"] = 13;
            powerCard["A"] = 14;

            return powerCard;
        }

        public static Dictionary<string, int> getTypeOfCard()
        {
            var typeCard = new Dictionary<string, int>();

            typeCard["S"] = 4;
            typeCard["H"] = 3;
            typeCard["D"] = 2;
            typeCard["C"] = 1;

            return typeCard;
        }
    }
}
