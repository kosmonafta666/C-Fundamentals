using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello";
            string str2 = "World";

            var obj = str1 + " " + str2;

            string str3 = (string)obj;

            Console.WriteLine(obj);
        }
    }
}
