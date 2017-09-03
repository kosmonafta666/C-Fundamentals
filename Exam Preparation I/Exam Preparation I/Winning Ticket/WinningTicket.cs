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
            var input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var ticket in input)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string pattern = @"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}";
                    Regex regex = new Regex(pattern);

                    string leftStr = ticket.Substring(0, ticket.Length / 2);
                    string rigthStr = ticket.Substring(ticket.Length / 2);
                    Match leftMatch = regex.Match(leftStr);
                    Match rightMatch = regex.Match(rigthStr);
                    var minLength = Math.Min(leftMatch.Length, rightMatch.Length);

                    if ( leftMatch.ToString().Substring(0, minLength) == rightMatch.ToString().Substring(0, minLength) )
                    {
                        if (leftMatch.Length == 10 && rightMatch.Length == 10)
                        {
                            Console.WriteLine("ticket \"{0}\" - 10{1} Jackpot!", ticket, leftMatch.ToString()[0]);
                        }
                        else if (leftMatch.Length >= 6 && rightMatch.Length >= 6)
                        {
                            Console.WriteLine("ticket \"{0}\" - {1}{2}", ticket, minLength, leftMatch.ToString()[0]);
                        }
                        else
                        {
                            Console.WriteLine("ticket \"{0}\" - no match", ticket);
                        }
                    }
                    else
                    {
                        Console.WriteLine("ticket \"{0}\" - no match", ticket);
                    }
                }
            }
        }
    }
}
