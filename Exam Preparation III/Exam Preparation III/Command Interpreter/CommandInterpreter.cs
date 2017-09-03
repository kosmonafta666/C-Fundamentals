namespace Command_Interpreter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class CommandInterpreter
    {
        public static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ');
            //var result = new string[arr.Length];
            //start commands
            var command = Console.ReadLine();

            while (command != "end")
            {
                var token = command.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                //check for valid input
                if (CheckInput(token))
                {
                    if (token[0] == "reverse")
                    {
                        int start;
                        int count;
                        
                        if (int.TryParse(token[2], out start) && int.TryParse(token[4], out count))
                        {
                            if (start >= 0 && count >= 0)
                            {
                                arr = ReverseArr(arr, start, count);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                        }
                    }
                    else if (token[0] == "sort")
                    {
                        int start;
                        int count;
                        if (int.TryParse(token[2], out start) && int.TryParse(token[4], out count))
                        {
                            if (start >= 0 && count >= 0)
                            {
                                arr = SortArr(arr, start, count);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                        }
                    }
                    else if (token[0] == "rollRight")
                    {
                        int count;
                        if (int.TryParse(token[1], out count))
                        {
                            if (count >= 0)
                            {
                                arr = rollRight(arr, count);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                        }
                    }
                    else if (token[0] == "rollLeft" )
                    {
                        int count;
                        if (int.TryParse(token[1], out count))
                        {
                            if (count >= 0)
                            {
                                arr = rollLeft(arr, count);
                            }
                            else
                            {
                                Console.WriteLine("Invalid input parameters.");
                            }
                        }
                    }
                }//end of checking for valid input;

                command = Console.ReadLine();
            }//end of while loop;

            Console.WriteLine("[{0}]", string.Join(", ", arr));
        }

       
        //check if input is valid
        public static bool CheckInput(string[] input)
        {
            bool flag = false;

            if (input[0] == "reverse" || input[0] == "sort" || input[0] == "rollLeft" || input[0] == "rollRight")
            {
                flag = true;
            }

            return flag;
        }

        //method for reverse portion of array
        public static string[] ReverseArr(string[] arr, int start, int count)
        {
            //check for valid input;
            if (start >= 0 && start < arr.Length && (start + count >= 0) && (start + count <= arr.Length))
            {
                //new arr;
                var result = new string[arr.Length];

                //divide arr to 3 sub arrays;
                string[] subStr1 = arr.Take(start).ToArray();
                string[] subStr2 = arr.Skip(start).Take(count).ToArray();
                string[] subStr3 = arr.Skip(start + count).Take(arr.Length - (start + count)).ToArray();

                //cancat subarrays;
                result = subStr1.Concat(subStr2.Reverse()).ToArray();
                result = result.Concat(subStr3).ToArray();

                return result;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }
        }

        //method to sort portion of array
        public static string[] SortArr(string[] arr, int start, int count)
        {
            //check for valid input;
            if (start >= 0 && start < arr.Length && (start + count >= 0) && (start + count <= arr.Length))
            {
                //new arr;
                var result = new string[arr.Length];

                //divide arr to 3 sub arrays;
                string[] subStr1 = arr.Take(start).ToArray();
                string[] subStr2 = arr.Skip(start).Take(count).ToArray();
                string[] subStr3 = arr.Skip(start + count).Take(arr.Length - (start + count)).ToArray();

                result = subStr1.Concat(subStr2.OrderBy(x => x)).ToArray();
                result = result.Concat(subStr3).ToArray();

                return result;
            }
            else
            {
                Console.WriteLine("Invalid input parameters.");
                return arr;
            }
             
        }

        //method for roll left array by given count;
        public static string[] rollRight(string[] arr, int count)
        {
            string[] result = new string[arr.Length];

            for (int j = 0; j < arr.Length; j++)
            {
                 result[(j + count) % arr.Length] = arr[j];
            }
           
            return result;
        }

        //method for roll right array by given count;
        public static string[] rollLeft(string[] arr, int count)
        {
            string[] result = new string[arr.Length];

            for (int j = 0; j < arr.Length; j++)
            {
                result[j] = arr[(j + count) % arr.Length];
            }

            return result;
        }

    }
}
