using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            int commonEnd = LargestCommonEnd(arr1, arr2);

            Console.WriteLine(commonEnd);
        }

        public static int LargestCommonEnd(string[] arr1, string[] arr2)
        {
            int counterLeft = 0;
            int counterRight = 0;
            int len1 = arr1.Length;
            int len2 = arr2.Length;
            int diffLength = Math.Abs(len1 - len2);
            

            if (len1 <= len2)
            {
                for (int i = 0; i < len1; i++)
                {
                    if (arr1[i] == arr2[i])
                    {
                        counterLeft++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = len1 - 1; i >= 0; i--)
                {
                    if (arr1[i] == arr2[i + diffLength])
                    {
                        counterRight++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            else if (len2 <= len1) 
            {
                for (int i = 0; i < len2; i++)
                {
                    if (arr2[i] == arr1[i])
                    {
                        counterLeft++;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int i = len2 - 1; i >= 0; i--)
                {
                    if (arr2[i] == arr1[i + diffLength])
                    {
                        counterRight++;
                    }
                    else 
                    {
                        break;
                    } 
                }
            }
            

            int maxCounter = Math.Max(counterLeft, counterRight);
            
            return maxCounter;
        }
    }
}
