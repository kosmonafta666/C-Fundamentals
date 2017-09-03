using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr1 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            var arr2 = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();

            CompareCharArrays(arr1, arr2);
        }

        private static void CompareCharArrays(char[] arr1, char[] arr2)
        {

            string arrStr1 = string.Join("", arr1);
            string arrStr2 = string.Join("", arr2);

            if (arr1.Length < arr2.Length)
            {
                Console.WriteLine("{0}", arrStr1);
                Console.WriteLine("{0}", arrStr2);
            }
            else if (arr2.Length < arr1.Length)
            {
                Console.WriteLine("{0}", arrStr2);
                Console.WriteLine("{0}", arrStr1);
            }
            else if (arr1.Length == arr2.Length)
            {
                for (int i = 0; i < arr1.Length; i++)
                {
                    if (arr1[i] < arr2[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", arr1), string.Join("", arr2));
                        break;
                    }
                    else if (arr2[i] < arr1[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", arr2), string.Join("", arr1));
                        break;
                    }
                    else if (arr2[i] == arr1[i])
                    {
                        Console.WriteLine("{0}\n{1}", string.Join("", arr1), string.Join("", arr2));
                        break;
                    }
                }
            }
        }
    }
}
