using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());

            string hex = Convert.ToString(num, 16);
            hex = hex.ToUpper();
            string bin = Convert.ToString(num, 2);

            Console.WriteLine(hex);
            Console.WriteLine(bin);
        }
    }
}
