namespace Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class LadyBugs
    {
        public static void Main(string[] args)
        {
            var fieldLength = int.Parse(Console.ReadLine());
            var bugIndexes = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            //field for bugs;
            var bugField = new int [fieldLength];

            //plant bugs in bugs field;
            for (int i = 0; i < bugIndexes.Count; i++)
            {
                var index = bugIndexes[i];
                if (index >= 0 && index < bugField.Length)
                {
                    bugField[index] = 1;
                }
            }

            var line = Console.ReadLine();

            while (line != "end")
            {
                var token = line.Split(' ').ToArray();
                var indexBug = int.Parse(token[0]);
                var direction = token[1];
                var step = int.Parse(token[2]);

                //check if have a valid index bugs
                if (indexBug >= 0 && indexBug < bugField.Length)
                {
                    //check if have a bug and fly 
                    if (bugField[indexBug] == 1)
                    {
                        bugField[indexBug] = 0;

                        //checking the directionand step
                        if (direction == "right" && step >= 0)
                        {
                            MoveRight(bugField, indexBug, Math.Abs(step));
                        }
                        else if (direction == "right" && step < 0)
                        {
                            MoveLeft(bugField, indexBug, Math.Abs(step));
                        }
                        else if (direction == "left" && step >= 0)
                        {
                            MoveLeft(bugField, indexBug, Math.Abs(step));
                        }
                        else if (direction == "left" && step < 0)
                        {
                            MoveRight(bugField, indexBug, Math.Abs(step));
                        }
                    }//end of check if have a buf
                }//end of check for valid index bugs
               
                line = Console.ReadLine();
            }

            //printing the result
            foreach (var index in bugField)
            {
                Console.Write("{0} ", index);
            }
        }

        //moving right;
        public static void MoveRight (int[] bugField, int indexBug, int step) 
        {
            for (int i = indexBug + step; i < bugField.Length; i = i + step) 
            {
                if (bugField[i] == 0)
                {
                    bugField[i] = 1;
                    break;
                }
            }

        }

        //moving left;
        public static void MoveLeft(int[] bugField, int indexBug, int step)
        {
            for (int i = indexBug - step; i >= 0; i = i - step)
            {
                if (bugField[i] == 0)
                {
                    bugField[i] = 1;
                    break;
                }
            }

        }
    }
}
