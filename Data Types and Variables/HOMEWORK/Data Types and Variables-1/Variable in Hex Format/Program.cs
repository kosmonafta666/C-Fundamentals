using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            var numStr = Console.ReadLine();

            int num = Convert.ToInt32(numStr, 16);

            Console.WriteLine(num);
        }
    }
}
