namespace Fix_Emails
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class FixEmails
    {
        public static void Main(string[] args)
        {
            var line = Console.ReadLine();
            var emailAddress = new Dictionary<string, string>();

            while (line != "stop")
            {
                var name = line;
                var email = Console.ReadLine();

                emailAddress[name] = email;

                line = Console.ReadLine();
            }

            Dictionary<string, string> fixedEmails = new Dictionary<string, string>();

            fixedEmails = emailAddress
                .Where(x => !x.Value.ToLower().EndsWith("us") && !x.Value.ToLower().EndsWith("uk"))
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in fixedEmails)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
