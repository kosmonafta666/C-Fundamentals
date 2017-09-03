using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = BigInteger.Parse(Console.ReadLine());

            if (num > long.MaxValue || num < long.MinValue)
            {
                Console.WriteLine("{0} can't fit in any type", num);
            }
            else
            {
                Console.WriteLine("{0} can fit in: ", num);

                if (num <= sbyte.MaxValue && num >= sbyte.MinValue)
                {
                    Console.WriteLine("* sbyte");
                }
                if (num <= byte.MaxValue && num >= byte.MinValue)
                {
                    Console.WriteLine("* byte");
                }
                if (num <= short.MaxValue && num >= short.MinValue)
                {
                    Console.WriteLine("* short");
                }
                if (num <= ushort.MaxValue && num >= ushort.MinValue)
                {
                    Console.WriteLine("* ushort");
                }
                if (num <= int.MaxValue && num >= int.MinValue)
                {
                    Console.WriteLine("* int");
                }
                if (num <= uint.MaxValue && num >= uint.MinValue)
                {
                    Console.WriteLine("* uint");
                }
                if (num <= long.MaxValue && num >= long.MinValue)
                {
                    Console.WriteLine("* long");
                }
            }
        }
    }
}
