namespace Winning_Ticket
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Text.RegularExpressions;

    public class WinningTicket
    {
        public static void Main(string[] args)
        {
            //split the input and create ticket list;
            var ticketList = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var ticket in ticketList)
            {
                //regex to find match;
                Regex regexMatch = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");

                //string for left half;
                string leftHalf = ticket.Substring(0, ticket.Length / 2);
                //string for right half;
                string rightHalf = ticket.Substring(ticket.Length / 2);

                //check for valid ticket;
                if (ticket.Length == 20)
                {
                    //match for left half;
                    Match leftMatch = regexMatch.Match(leftHalf);
                    //match for right half;
                    Match rightMatch = regexMatch.Match(rightHalf);
                    //var for left match length;
                    int leftMatchLength = leftMatch.Length;
                    //var for right match length;
                    int rightMatchLength = rightMatch.Length;
                    //var for min lenght;
                    var minLength = Math.Min(leftMatchLength, rightMatchLength);

                    //check for equal matches;
                    if ( leftMatch.ToString().Substring(0, minLength) == rightMatch.ToString().Substring(0, minLength) )
                    {
                        //check for winning ticket;
                        if (leftMatchLength == 10 && rightMatchLength == 10)
                        {
                            //var for winning symbol;
                            char winningSymbol = leftMatch.ToString()[0];
                            Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!", ticket, winningSymbol);
                        }
                        else if ((leftMatchLength >= 6 ) && (rightMatchLength >= 6 ))
                        {
                            //var for min value match;
                            var minCount = Math.Min(leftMatchLength, rightMatchLength);
                            //var for winning symbol;
                            char winningSymbol = leftMatch.ToString()[0];
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, minCount, winningSymbol);
                        }//end of check for winning ticket;
                        else
                        {
                            Console.WriteLine("ticket \"{0}\" - no match", ticket);
                        }
                    }//end of check for equal matches;
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                    
                }//end of check for valid ticket;
                else
                {
                    Console.WriteLine("invalid ticket");
                }

            }//end of foreach loop;
        }
    }
}
