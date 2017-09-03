namespace AndreyAndBilliard_1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class AndreyAndBilliard
    {
        public static void Main(string[] args)
        {
            var numberOfEntity = int.Parse(Console.ReadLine());

            var entities = new Dictionary<string, decimal>();

            for (int i = 1; i <= numberOfEntity; i++) 
            {
                var menu = Console.ReadLine().Split('-').ToArray();

                if (!entities.ContainsKey(menu[0]))
                {
                    entities.Add(menu[0], decimal.Parse(menu[1]));
                }
                else
                {
                    entities[menu[0]] = decimal.Parse(menu[1]);
                }
            }

            List<Customer> listOfCustomer = new List<Customer>();

            while (true)
            {
                char[] splitOption = new char[2] { '-', ',' };
                var token = Console.ReadLine().Split(splitOption).ToArray();
                if (token[0] == "end of clients")
                {
                    break;
                }

                string nameOfCustomer = token[0];
                string product = token[1];
                int quantity = int.Parse(token[2]);

                if (!entities.ContainsKey(product))
                {
                    continue;
                }

                Customer currentCustomer = new Customer();
                currentCustomer.Name = nameOfCustomer;
                currentCustomer.OrderList = new Dictionary<string, int>();
                currentCustomer.OrderList[product] = quantity;

                if (listOfCustomer.Any(x => x.Name == nameOfCustomer))
                {
                    var existingCustomer = listOfCustomer.First(x => x.Name == nameOfCustomer);
                    if (existingCustomer.OrderList.ContainsKey(product))
                    {
                        existingCustomer.OrderList[product] += quantity;
                    }
                    else
                    {
                        existingCustomer.OrderList[product] = quantity;
                    }
                }
                else
                {
                    listOfCustomer.Add(currentCustomer);
                }
            }

            var sortedListOfCustomer = listOfCustomer.OrderBy(x => x.Name);
            decimal totalBill = 0m;

            foreach (var customer in sortedListOfCustomer)
            {
                decimal bill = 0m;
                Console.WriteLine("{0}", customer.Name);

                foreach (var item in customer.OrderList)
                {
                    Console.WriteLine("-- {0} - {1}", item.Key, item.Value);
                    bill += item.Value * entities[item.Key];
                }

                totalBill += bill;
                Console.WriteLine("Bill: {0:F2}", bill);
            }

            Console.WriteLine("Total bill: {0:F2}", totalBill);
        }
    }
}
