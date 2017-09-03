namespace Phonebook
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class PhonebookUpgarde
    {
        public static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var phonebook = new Dictionary<string, string>();

            while (command != "END")
            {
                var splitCommand = command.Split(' ').ToList();

                if (splitCommand[0] == "A")
                {
                    AddContact(phonebook, splitCommand[1], splitCommand[2]);
                }
                else if (splitCommand[0] == "S")
                {
                    SearchContact(phonebook, splitCommand[1]);
                }
                else if (splitCommand[0] == "ListAll")
                {
                    PrintPhonebook(phonebook);
                }
                

                command = Console.ReadLine();
            }
        }

        public static void AddContact(Dictionary<string, string> phonebook, string name, string number)
        {
            phonebook[name] = number;
        }

        public static void SearchContact(Dictionary<string, string> phonebook, string name)
        {
            if (!phonebook.ContainsKey(name))
            {
                Console.WriteLine("Contact {0} does not exist.", name);
            }
            else
            {
                Console.WriteLine("{0} -> {1}", name, phonebook[name]);
            }
        }

        public static void PrintPhonebook(Dictionary<string, string> phonebook)
        {
            var sortedPhonebook = phonebook.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in sortedPhonebook)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }

        }
    }
}
