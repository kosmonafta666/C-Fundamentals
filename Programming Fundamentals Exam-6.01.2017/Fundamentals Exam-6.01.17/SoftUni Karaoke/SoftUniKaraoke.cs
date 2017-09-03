namespace SoftUni_Karaoke
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SoftUniKaraoke
    {
        public static void Main(string[] args)
        {
            //list for participants;
            var participants = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            //list for songs
            var songs = Console.ReadLine()
                .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToList();

            //dictionary for participants with awards;
            var result = new Dictionary<string, List<string>>();

            //var for input;
            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var token = input
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x.Trim())
                    .ToArray();

                //var for singer on the stage;
                var participant = token[0];
                //var for song for the singer;
                var song = token[1];
                //var for award;
                var award = token[2];

                //check if singer is listed;
                if (participants.Contains(participant))
                {
                    if (!result.ContainsKey(participant))
                    {
                        result[participant] = new List<string>();
                    }

                    var awards = result[participant];
                    //check if song is listed in songs list;
                    if (songs.Contains(song) && !awards.Contains(award))
                    {
                        awards.Add(award);
                    }
                }

                input = Console.ReadLine();
            }//end of while loop;


            //printing the result;
            if (result.Any())
            {
                foreach (var kvp in result
                    .OrderByDescending(p => p.Value.Count)
                    .ThenBy(p => p.Key))
                {
                    if (kvp.Value.Any())
                    {
                        var participant = kvp.Key;
                        var awards = kvp.Value;

                        Console.WriteLine("{0}: {1} awards", participant, awards.Count);

                        foreach (var award in awards.OrderBy(p => p))
                        {
                            Console.WriteLine("--{0}", award);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }//end of printing the result;
        }
    }
}
