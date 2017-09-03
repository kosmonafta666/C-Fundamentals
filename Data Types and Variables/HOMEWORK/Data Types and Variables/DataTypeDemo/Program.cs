using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger someValue = 1;

            for (int i = 0; i < 1000; i++)
            {
                someValue *= long.MaxValue;
            }

            Console.WriteLine(someValue);
        }
    }
}
