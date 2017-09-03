namespace Sales_Report
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class SalesReport
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            List<Sale> listOfSales = ListOfSales(n);

            SortedDictionary<string, double> salesByTown= new SortedDictionary<string, double>();

            for (int i = 0; i < listOfSales.Count; i++)
            {
                var key = listOfSales[i].Town;
                var price = listOfSales[i].Price * listOfSales[i].Quantity;

                if (!salesByTown.ContainsKey(key))
                {
                    salesByTown[key] = price;
                }
                else
                {
                    salesByTown[key] += price;
                }
            }

            foreach (var item in salesByTown)
            {
                Console.WriteLine("{0} -> {1:F2}", item.Key, item.Value);
            }
        }

        public static List<Sale> ListOfSales(int n)
        {

            List<Sale> list = new List<Sale>();

            for (int i = 1; i <= n; i++)
            {
                var line = Console.ReadLine().Split(' ').ToArray();

                var sale = new Sale()
                {
                    Town = line[0],
                    Product = line[1],
                    Price = double.Parse(line[2]),
                    Quantity = double.Parse(line[3])
                };

                list.Add(sale);
            }

            return list;
        }
    }
}
