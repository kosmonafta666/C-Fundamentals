using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Index_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine();

            for (int i = 0; i < arr.Length; i++)
            {
                int charNumber = 0;
                charNumber = arr[i] - 'a';
                Console.WriteLine("{0} -> {1}", arr[i], charNumber);
            }
        }
    }
}
