namespace Roli_The_Coder
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class RoliTheCoder
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();

            //dictionary for events;
            Dictionary<string, Event> dictEvent = new Dictionary<string, Event>();

            while (input != "Time for Code")
            {
                //initializing the input;
                var token = input.Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                var id = token[0];
                var name = token[1];

                //checking if the input is valid;
                if ((char)name[0] == '#')
                {
                    //check if id exist in dict event if any filled dict event
                    if (!dictEvent.ContainsKey(id))
                    {
                        Event currEvent = new Event();
                        currEvent.Name = name;
                        currEvent.Participants = new HashSet<string>();
                       
                        //adding to participant to list;
                        for (int i = 2; i < token.Length; i++)
                        {
                            var participant = token[i];
                            if ((char)participant[0] == '@')
                            {
                                currEvent.Participants.Add(participant);
                            }
                        }
             
                        //adding to dictEvent;
                        dictEvent[id] = currEvent;
                    }
                    else if (dictEvent.ContainsKey(id) && (dictEvent[id].Name == name))
                    {
                        for (int i = 2; i < token.Length; i++)
                        {
                            var participant = token[i];
                            if ((char)participant[0] == '@')
                            {
                                dictEvent[id].Participants.Add(participant);
                            }
                        }
                    }

                }//end of checking the valid input;

                input = Console.ReadLine();
            }//end of while loop;

            //sorted dictionary 
            var sortedDict = dictEvent.OrderByDescending(x => x.Value.Participants.Count).ThenBy(x => x.Value.Name).ToDictionary(x => x.Key, x => x.Value);

            //printig the result;
            foreach (var item in sortedDict)
            {
                var name = item.Value.Name.Substring(1, item.Value.Name.Length - 1);
                Console.WriteLine("{0} - {1}", name, item.Value.Participants.Count);

                foreach (var participant in item.Value.Participants.OrderBy(x => x))
                {
                    Console.WriteLine(participant);
                }
            }
        }
    }
}
