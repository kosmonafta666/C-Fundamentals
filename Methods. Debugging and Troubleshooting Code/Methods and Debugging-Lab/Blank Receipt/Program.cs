using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blank_Receipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        public static void PrintHeaderReceipt()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine("------------------------------");
        }

        public static void PrintBodyReceipt()
        {
            Console.WriteLine("Charged to____________________");
            Console.WriteLine("Received by___________________");
        }

        public static void PrintFooterReceipt()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("© SoftUni");
        }

        public static void PrintReceipt()
        {
            PrintHeaderReceipt();
            PrintBodyReceipt();
            PrintFooterReceipt();
        }


    }
}
