using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());

            for (int i = num1; i <= num2; i++)
            {
                char ansi = (char)i;
                Console.Write(ansi + " ");
            }

            Console.WriteLine();
        }
    }
}
