namespace Array_Manipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ArrayManipulator
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var token = command.Split(' ').ToArray();

                if (token[0] == "exchange")
                {
                    arr = ExchangeArray(arr, int.Parse(token[1]));
                }
                else if (token[0] == "max")
                {
                    MaxOddOrEvenNumber(arr, token[1]);
                }
                else if (token[0] == "min")
                {
                    MinOddOrEvenNumber(arr, token[1]);
                }
                else if (token[0] == "first")
                {
                    FirstEvenOrOdd(arr, int.Parse(token[1]), token[2]);
                }
                else if (token[0] == "last")
                {
                    LastEvenOrOdd(arr, int.Parse(token[1]), token[2]);
                }
                command = Console.ReadLine();
            }//end of while loop

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

       
       
        //exchange the array by given index;
        public static int[] ExchangeArray(int[] arr, int index)
        {
            int[] result = new int[arr.Length];

            if (index < arr.Length && index >= 0)
            {
                var firstArr = arr.Take(index + 1).ToArray();
                var secondArr = arr.Skip(index + 1).Take(arr.Length - (index + 1));

                result = secondArr.Concat(firstArr).ToArray();
            }
            else
            {
                Console.WriteLine("Invalid index");
                result = arr;
            }

            //Console.WriteLine(String.Join(" ", result));
            return result;
        }

        //printing the max odd or even number index;
        public static void MaxOddOrEvenNumber(int[] arr, string oddOrEven)
        {
            //var max value;
            int max = 0;
            int index = 0;

            if (oddOrEven == "odd")
            {
                try
                {
                    max = arr.Where(x => x % 2 != 0).Max();
                    index = Array.LastIndexOf(arr, max);
                }
                catch
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (oddOrEven == "even")
            {
                try
                {
                    max = arr.Where(x => x % 2 == 0).Max();
                    index = Array.LastIndexOf(arr, max);

                }
                catch
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }

            Console.WriteLine(index);
        }

        //printin min odd or even number index;
        public static void MinOddOrEvenNumber(int[] arr, string oddOrEven)
        {
            //var max value;
            int max = 0;
            int index = 0;

            if (oddOrEven == "odd")
            {
                try
                {
                    max = arr.Where(x => x % 2 != 0).Min();
                    index = Array.LastIndexOf(arr, max);
                }
                catch
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }
            else if (oddOrEven == "even")
            {
                try
                {
                    max = arr.Where(x => x % 2 == 0).Min();
                    index = Array.LastIndexOf(arr, max);

                }
                catch
                {
                    Console.WriteLine("No matches");
                    return;
                }
            }

            Console.WriteLine(index);
        }

        //printing the pair of first pair of even or odd numbers;
        public static void FirstEvenOrOdd(int[] arr, int count, string oddOrEven)
        {
            //check for valid count;
            if (count <= arr.Length)
            {
                var result = new List<int>();

                if (oddOrEven == "odd")
                {
                    try
                    {
                        var oddNumbers = arr.Where(x => x % 2 != 0).ToArray();
 
                        if (count >= oddNumbers.Length)
                        {
                            for (int i = 0; i < oddNumbers.Length; i++)
                            {
                                result.Add(oddNumbers[i]);
                            }
                        }
                        else if (oddNumbers.Length >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                result.Add(oddNumbers[i]);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("[]");
                        return;
                    }

                }//end of check for odd numbers;
                else if (oddOrEven == "even")
                {
                    try
                    {
                        var evenNumbers = arr.Where(x => x % 2 == 0).ToArray();

                        if (evenNumbers.Length >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                result.Add(evenNumbers[i]);
                            }
                        }
                        else
                        {
                            for (int i = 0; i < evenNumbers.Length; i++)
                            {
                                result.Add(evenNumbers[i]);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("[]");
                        return;
                    }

                }//end of check for even numbers;

                //printing the result;
                Console.WriteLine("[{0}]", string.Join(", ", result));

            }//end of check for valid count
            else
            {
                Console.WriteLine("Invalid count");
            }
        }


        //printing the pair of first pair of even or odd numbers;
        public static void LastEvenOrOdd(int[] arr, int count, string oddOrEven)
        {
            //check for valid count;
            if (count <= arr.Length)
            {
                var result = new List<int>();

                if (oddOrEven == "odd")
                {
                    try
                    {
                        var oddNumbers = arr.Where(x => x % 2 != 0).ToArray();

                        if (count >= oddNumbers.Length)
                        {
                            for (int i = 0; i < oddNumbers.Length; i++)
                            {
                                result.Add(oddNumbers[(oddNumbers.Length - 1) - i]);
                            }
                        }
                        else if (oddNumbers.Length >= count)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                result.Add(oddNumbers[(oddNumbers.Length - 1) - i]);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("[]");
                        return;
                    }

                }//end of check for odd numbers;
                else if (oddOrEven == "even")
                {
                    try
                    {
                        var evenNumbers = arr.Where(x => x % 2 == 0).ToArray();

                        if (count >= evenNumbers.Length)
                        {
                            for (int i = 0; i < evenNumbers.Length; i++)
                            {
                                result.Add(evenNumbers[(evenNumbers.Length - 1) - i]);
                            }
                        }
                        else if (evenNumbers.Length >= count)
                        {

                            for (int i = 0; i < count; i++)
                            {
                                result.Add(evenNumbers[(evenNumbers.Length - 1) - i]);
                            }
                        }
                    }
                    catch
                    {
                        Console.WriteLine("[]");
                        return;
                    }

                }//end of check for even numbers;

                result.Reverse();
                //printing the result;
                Console.WriteLine("[{0}]", string.Join(", ", result));

            }//end of check for valid count
            else
            {
                Console.WriteLine("Invalid count");
            }
        }

    }
}
