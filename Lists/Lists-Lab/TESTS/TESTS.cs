namespace TESTS
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TESTS
    {
        public static void Main(string[] args)
        {
            var listOfNumbers = new List<int>();

            listOfNumbers.Add(-10);
            listOfNumbers.Add(20);
            listOfNumbers.Add(-30);
            listOfNumbers.Add(40);

            //Console.WriteLine(listOfNumbers.Contains(-30));
            listOfNumbers.Sort();
            listOfNumbers.Reverse();
            foreach (var number in listOfNumbers)
            {
                Console.WriteLine(number);
            }

            //Console.WriteLine(listOfNumbers.Count);
        }
    }
}
