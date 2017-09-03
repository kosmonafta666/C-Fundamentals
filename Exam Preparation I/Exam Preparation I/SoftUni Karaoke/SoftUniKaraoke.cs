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
            //splitting participant and added to list
            var participants = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<Participant> listParticipant = new List<Participant>();

            foreach (var participant in participants)
            {
                Participant currentParticipant = new Participant();
                currentParticipant.Name = participant;
                currentParticipant.Awards = new HashSet<string>();
                listParticipant.Add(currentParticipant);
            }

            //spliting songs and added to list
            var songs = Console.ReadLine().Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim());

            List<string> listSongs = new List<string>();

            foreach (var song in songs)
            {
                listSongs.Add(song);
            }

            //input participant, songs and awards in karaoke
            var input = Console.ReadLine();

            while (input != "dawn")
            {
                var token = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();

                var user = token[0];
                var song = token[1];
                var award = token[2];
                
                var existParticipant = CheckParticipant(listParticipant, user);
                var existSong = CheckSongs(listSongs, song);

                if (existParticipant && existSong)
                {
                    InsertAwards(listParticipant, user, award);
                }

                input = Console.ReadLine();
            }

            PrintParticipant(listParticipant);
        }

        //check if user exist in participant list;
        public static bool CheckParticipant(List<Participant> listParticipant, string name)
        {
            bool flag = false;

            foreach (var participant in listParticipant)
            {
                if (participant.Name == name)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        //check if song exist in songs list
        public static bool CheckSongs(List<string> listSongs, string name)
        {
            bool flag = false;

            foreach (var song in listSongs)
            {
                if (song == name)
                {
                    flag = true;
                    break;
                }
            }

            return flag;
        }

        //insert award in participant award list;
        public static void InsertAwards(List<Participant> listParticipant, string name, string award)
        {

            foreach (var participant in listParticipant)
            {
                if (participant.Name == name)
                {
                    participant.Awards.Add(award);
                }
            }
        }

        //print participant;
        public static void PrintParticipant(List<Participant> listParticipant)
        {
            var sortedList = listParticipant.OrderByDescending(x => x.Awards.Count).ThenBy(x => x.Name).ToList();
            var countAwards = 0;

            foreach (var participant in sortedList)
            {
                if (participant.Awards.Count > 0)
                {
                    Console.WriteLine("{0}: {1} awards", participant.Name, participant.Awards.Count);

                    var sortedAwards = participant.Awards.OrderBy(x => x);

                    foreach (var award in sortedAwards)
                    {
                        Console.WriteLine("--{0}", award);
                    }

                    countAwards++;
                }
            }

            if (countAwards == 0)
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
