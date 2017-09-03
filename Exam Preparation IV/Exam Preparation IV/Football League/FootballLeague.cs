namespace Football_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class FootballLeague
    {
        public static  void Main(string[] args)
        {
            var key = Console.ReadLine();
            key = Regex.Escape(key);
            //dictionary for the teams;
            Dictionary<string, int> dictTeams = new Dictionary<string, int>();
            //dictionary for goals;
            Dictionary<string, int> dictGoals = new Dictionary<string, int>();

            var command = Console.ReadLine();

            while (command != "final")
            {
                //string for pattern with group to extract;
                string pattern = String.Format(@"{0}(.*?){0}", key);
                //regex for extract teams;
                Regex regex = new Regex(pattern);
                var matches = regex.Matches(command);
                if (matches.Count == 1)
                {

                }
                //var for scores;
                var score1 = int.Parse(command.Split(' ').Last().Split(':')[0]);
                var score2 = int.Parse(command.Split(' ').Last().Split(':')[1]);

                //var for values for dict;
                var valueDict1 = 0;
                var valueDict2 = 0;

                if (score1 > score2) 
                {
                    valueDict1 = 3;
                    valueDict2 = 0;
                }
                else if (score1 == score2) 
                {
                    valueDict1 = 1;
                    valueDict2 = 1;
                }
                else if (score1 < score2)
                {
                    valueDict1 = 0;
                    valueDict2 = 3;
                }

                //var for key in dict;
                var keyDict1 = matches[0].Groups[1].ToString();
                keyDict1 = new string(keyDict1.Reverse().ToArray());
                var keyDict2 = matches[1].Groups[1].ToString();
                keyDict2 = new string(keyDict2.Reverse().ToArray());

                //fill the dictionary for teams;
                FillDictionary(dictTeams, keyDict1.ToUpper(), valueDict1);
                FillDictionary(dictTeams, keyDict2.ToUpper(), valueDict2);

                //fill the dictionary for goals;
                FillDictionary(dictGoals, keyDict1.ToUpper(), score1);
                FillDictionary(dictGoals, keyDict2.ToUpper(), score2);

                command = Console.ReadLine();
            }//end of while loop;

            //var for count inthe begining of output;
            var count = 1;
            //create sorted Dict for teams;
            var sortedDictTeams = dictTeams.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            //printing teamsk
            Console.WriteLine("League standings:");

            foreach (var item in sortedDictTeams)
            {
                Console.WriteLine("{0}. {1} {2}", count, item.Key, item.Value);
                count++;
            }

            //create sorted Dict for players;
            var sortedDictGoals = dictGoals.OrderByDescending(x => x.Value).ThenBy(x => x.Key);

            Console.WriteLine("Top 3 scored goals:");

            //printing goals;
            foreach (var item in sortedDictGoals.Take(3))
            {
                Console.WriteLine("- {0} -> {1}", item.Key, item.Value);
            }
        }

        //method for fill the dictionary;
        public static void FillDictionary(Dictionary<string, int> dict, string key, int value)
        {
            if (!dict.ContainsKey(key))
            {
                dict.Add(key, value);
            }
            else if (dict.ContainsKey(key))
            {
                dict[key] += value;
            }
        }
    }
}
