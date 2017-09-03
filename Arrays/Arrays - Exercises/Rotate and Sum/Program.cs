using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var jump = int.Parse(Console.ReadLine());

            RotateAndSum(arr, jump);
        }

        private static void RotateAndSum(int[] arr, int jump)
        {
            int[] rotateArr = new int[arr.Length];
            int[] sum = new int[arr.Length];

            for (int i = 1; i <= jump; i++)
            {
                for (int j = 0; j < rotateArr.Length; j++)
                {
                    rotateArr[(j + i) % rotateArr.Length] = arr[j];
                }

                for (int k = 0; k < rotateArr.Length; k++)
                {
                    sum[k] += rotateArr[k];
                }
            }

            for (int i = 0; i < sum.Length; i++)
            {
                Console.Write("{0} ", sum[i]);
            }
            
        }
    }
}
