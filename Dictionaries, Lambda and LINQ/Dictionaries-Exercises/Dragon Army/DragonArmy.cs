namespace Dragon_Army
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class DragonArmy
    {
        public static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, decimal[]>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                var tokens = Console.ReadLine().Split();

                var type = tokens[0];
                var name = tokens[1];

                var damage = tokens[2] != "null" ? decimal.Parse(tokens[2]) : 45m;

                var health = tokens[3] != "null" ? decimal.Parse(tokens[3]) : 250m;

                var armor = tokens[4] != "null" ? decimal.Parse(tokens[4]) : 10m;

                if (!dragons.ContainsKey(type))
                {
                    dragons[type] = new SortedDictionary<string, decimal[]>();
                }

                dragons[type][name] = new decimal[] { damage, health, armor };

            }

            foreach (var type in dragons)
            {
                var typeName = type.Key;
                var dragonsByType = type.Value;
                var averageDamage = dragonsByType.Values.Average(x => x[0]);
                var averageHealth = dragonsByType.Values.Average(x => x[1]);
                var averageArmor = dragonsByType.Values.Average(x => x[2]);

                Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", typeName, averageDamage, averageHealth, averageArmor);

                foreach (var dragon in dragonsByType)
                {
                    var name = dragon.Key;
                    var damage = dragon.Value[0];
                    var health = dragon.Value[1];
                    var armor = dragon.Value[2];

                    Console.WriteLine("-{0} -> damage: {1}, health: {2}, armor: {3}", name, damage, health, armor);
                }
            }
        }
    }
}
