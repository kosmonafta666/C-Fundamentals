namespace A_Miner_Task
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MinerTask
    {
        public static void Main(string[] args)
        {
            var command = Console.ReadLine();

            var dictionary = new Dictionary<string, int>();
            var resources = new List<string>();
            var quantity = new List<int>();
            int count = 1;

            while (command != "stop") 
            {
                if (count % 2 != 0)
                {
                    resources.Add(command);
                }
                else if (count % 2 == 0)
                {
                    quantity.Add(Convert.ToInt32(command));
                }
                count++;
                command = Console.ReadLine();
            }

            for (int i = 0; i < resources.Count; i++)
            {
                if (!dictionary.ContainsKey(resources[i]))
                {
                    dictionary[resources[i]] = quantity[i];
                }
                else
                {
                    int newValue = dictionary[resources[i]] + quantity[i];
                    dictionary[resources[i]] = newValue;
                }
            }

            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
