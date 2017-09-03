using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrCh = new char[3];
            var ch1 = char.Parse(Console.ReadLine());
            arrCh[0] = ch1;
            var ch2 = char.Parse(Console.ReadLine());
            arrCh[1] = ch2;
            var ch3 = char.Parse(Console.ReadLine());
            arrCh[2] = ch3;

            for (int i = arrCh.Length - 1; i >= 0; i--)
            {
                Console.Write(arrCh[i]);
            }
                
        }
    }
}
