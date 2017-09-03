namespace Files
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Files
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //dictionary for files;
            var filesByRoot = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 1; i <= n; i++)
            {
                //input for files path amd size the split by path and size;
                var input = Console.ReadLine().Split('\\');

                //var for root;
                var root = input[0];
                //var for file
                var fileName = input.Last().Split(';')[0];

                //var for size;
                var fileSize = long.Parse(input.Last().Split(';')[1]);

                //fill the filesRoot dictionary;
                if (!filesByRoot.ContainsKey(root))
                {
                    filesByRoot.Add(root, new Dictionary<string, long>());
                }

                //if file name does not exist add if exist substitute with last one;
                if (!filesByRoot[root].ContainsKey(fileName))
                {
                    filesByRoot[root].Add(fileName, fileSize);
                }
                else
                {
                    filesByRoot[root][fileName] = fileSize;
                }
            }//end of for loop

            //read input for match;
            var match = Console.ReadLine().Split(' ');
            //var for extension match;
            var extensionMatch = match[0];
            //var root match;
            var rootMatch = match[2];
            //count for matches files found;
            var count = 0;

            //printing the result;
            foreach (var item in filesByRoot)
            {
                //create sortedDictionary;
                var sortedDict = item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
                if (rootMatch == item.Key)
                {
                    foreach (var file in sortedDict)
                    {
                        //check if extension exist;
                        if (file.Key.EndsWith(extensionMatch))
                        {
                            Console.WriteLine("{0} - {1} KB", file.Key, file.Value);
                            count++;
                        }
                    }
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
