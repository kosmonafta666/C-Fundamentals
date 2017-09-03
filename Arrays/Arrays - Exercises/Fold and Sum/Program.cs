using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            FoldAndSum(arr);
        }

        private static void FoldAndSum(int[] arr)
        {
            int k = arr.Length / 4;
            int fold1 = (2 * k) / 2;
            int fold2 = 2 * k;
            int[] foldArr1 = new int[arr.Length / 2];
            int[] foldArr2 = new int[arr.Length / 2];
            int[] sum = new int[arr.Length / 2];

            for (int i = 0; i < k; i++)
            {
                foldArr1[i] = arr[(k - 1)- i];
            }

            for (int i = 0; i < k; i++)
            {
                foldArr1[k + i] = arr[(arr.Length - 1) - i];
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                foldArr2[i] = arr[k + i];
            }

            for (int i = 0; i < arr.Length / 2; i++)
            {
                sum[i] = foldArr1[i] + foldArr2[i];
            }
            
            for (int i = 0; i < arr.Length / 2; i++)
            {
                Console.Write("{0} ", sum[i]);
            }       
             
        }
    }
}
