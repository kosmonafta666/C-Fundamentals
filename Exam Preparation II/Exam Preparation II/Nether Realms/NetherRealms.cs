namespace Nether_Realms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class NetherRealms
    {
        public static void Main(string[] args)
        {
            
            var input = Console.ReadLine().Split(new char [] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            List<Dragon> dragons = new List<Dragon>();

            for (int i = 0; i < input.Length; i++)
            {
                //initializing current object;
                Dragon currentDragon = new Dragon();
                currentDragon.Name = input[i];
                currentDragon.Healt = new List<double>();
                currentDragon.Damage = new List<double>();
                currentDragon.Optional = new List<string>();
                dragons.Add(currentDragon);

                //patterns for digit, word and options
                string patternDigit = @"[-|+]?([0-9]*\.[0-9]+|[0-9]+)";
                string patternWord = @"[^0-9.\/*+-]";
                string patternOpt = @"[*|\/]";

                //creating regex for digits, words and options;
                Regex regexDigit = new Regex(patternDigit);
                Regex regexWord = new Regex(patternWord);
                Regex regexOpt = new Regex(patternOpt);

                //extract digits and adding to object damage;
                var digitMatches = regexDigit.Matches(input[i]);
                foreach (Match match in digitMatches)
                {
                    var digit = double.Parse(match.ToString());
                    currentDragon.Damage.Add(digit);
                }

                //extract words and adding to object health;
                var wordMatches = regexWord.Matches(input[i]);
                foreach (Match match in wordMatches)
                {
                    var digit = Convert.ToInt32((char)match.ToString()[0]);
                    currentDragon.Healt.Add(digit);
                }

                //extract options
                var optMatches = regexOpt.Matches(input[i]);
                foreach (Match match in optMatches)
                {
                    currentDragon.Optional.Add(match.ToString());
                }

            }

            //sorted list for dragons;
            var sortedDragons = dragons.OrderBy(x => x.Name);

            //printing the result;
            foreach (var dragon in sortedDragons)
            {
                var healt = CalculateHealt(dragon.Healt);
                var damage = CalculateDamage(dragon.Damage, dragon.Optional);

                Console.WriteLine("{0} - {1} health, {2:F2} damage", dragon.Name, healt, damage);
            }
        }

        //calculating object health;
        public static double CalculateHealt(List<double> healt)
        {
            var result = 0.0;

            for (int i = 0; i < healt.Count; i++)
            {
                result += healt[i];
            }

            return result;
        }

        //calculating object damage;
        public static double CalculateDamage(List<double> damage, List<string> options)
        {
            var result = 0.0;
     
            if (damage.Count > 0)
            {
                for (int i = 0; i < damage.Count; i++)
                {
                    result += damage[i];
                }
            }

            if (options.Count > 0)
            {
                for (int i = 0; i < options.Count; i++)
                {
                    if (options[i] == "*")
                    {
                        result *= 2;
                    }
                    else if (options[i] == "/")
                    {
                        result /= 2;
                    }
                }
            }

            return result;
        }
    }
}
