namespace Hornet_Comm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class HornetComm
    {
        public static void Main(string[] args)
        {
            var input = Console.ReadLine();
            //Dictionary for private messages;
            Dictionary<string, string> privateMessages = new Dictionary<string,string>();
            //Dictionary for broadcast messages;
            Dictionary<string, string> broadcastMessages = new Dictionary<string, string>();

            //count for messages;
            int count = 1;
            int token1 = 0;
            while (input != "Hornet is Green")
            {
                
                //split the input;
                var token = input.Split(new string[] {" <-> " , " "}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                token1 = token[0].Length;
                //check for private messages;
                if (IsDigit(token[0]) == true && AnySymbols(token[1]) == false)
                {
                    //var for key;
                    var keyPrivate = count + new string(token[0].Reverse().ToArray());
                    //var for vlaue;
                    var valuePrivate = token[1];

                    //fill the private dictionary;
                    if (!privateMessages.ContainsKey(keyPrivate))
                    {
                        privateMessages.Add(keyPrivate, valuePrivate);
                    }
                    else
                    {
                        privateMessages[keyPrivate] = valuePrivate;
                    }
                }//end of chec for private messages;

                //chec for bradcast;
                if (IsDigit(token[0]) == false && AnySymbols(token[1]) == false)
                {
                    //var key broadcast;
                    var broadKey = InvertCasing(count + token[1]);
                    //var value broadcast
                    var broadValue = token[0];

                    //fill the broad dictionary;
                    if (!broadcastMessages.ContainsKey(broadKey))
                    {
                        broadcastMessages.Add(broadKey, broadValue);
                    }
                    else
                    {
                        broadcastMessages[broadKey] = broadValue;
                    }

                }//end of check for broadcast;

                count++;
                input = Console.ReadLine();
            }//end of while loop;

            //print the broad;
            Console.WriteLine("Broadcasts:");
            var countBroad = 0;
            foreach (var item in broadcastMessages)
            {
                var skipKey = "";
                skipKey = item.Key.Substring(1, item.Key.Length - 1);
              
                if (item.Key != null)
                {
                    Console.WriteLine("{0} -> {1}", skipKey, item.Value);
                    countBroad++;
                }
            }

            if (countBroad == 0)
            {
                Console.WriteLine("None");
            }

            //print the private messages;
            Console.WriteLine("Messages:");
            var countMessages = 0;
            
            foreach (var item in privateMessages)
            {
                var skipKey = "";
                skipKey = item.Key.Substring(1, item.Key.Length - 1);
                
               
                if (item.Key != null)
                {
                    Console.WriteLine("{0} -> {1}", skipKey, item.Value);
                    countMessages++;
                }
            }

            if (countMessages == 0)
            {
                Console.WriteLine("None");
            }
        }


        //check if input is only digit;
        public static bool IsDigit(string input)
        {
            bool flag = false;

            try
            {
                double.Parse(input);
                return flag = true;
            }
            catch
            {
                return flag = false;
            }
        }


        //check if have any digit in input
        public static bool AnyDigit(string input)
        {
            bool flag = true;

            foreach (var symbol in input)
            {
                if (Char.IsDigit(symbol))
                {
                    flag = false;
                }
            }

            return flag;
        }


        //check if have other symbols
        public static bool AnySymbols(string input)
        {
            bool flag = false;

            foreach (var symbol in input.ToUpper())
            {
                if (!Char.IsLetterOrDigit(symbol))
                {
                    flag = true;
                    //break;
                }
            }

            return flag;
        }


        //method for inverting the casing;
        public static string InvertCasing(string s)
        {
            char[] c = s.ToCharArray();
            char[] cUpper = s.ToUpper().ToCharArray();
            char[] cLower = s.ToLower().ToCharArray();

            for (int i = 0; i < c.Length; i++)
            {
                if (c[i] == cUpper[i])
                {
                    c[i] = cLower[i];
                }
                else
                {
                    c[i] = cUpper[i];
                }
            }

            return new string(c);
        }
    }
}
