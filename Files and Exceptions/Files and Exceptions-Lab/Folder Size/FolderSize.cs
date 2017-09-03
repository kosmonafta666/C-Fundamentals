namespace Folder_Size
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.IO;
    using System.Diagnostics;

    public class FolderSize
    {
        public static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");

            if (File.Exists("Output.txt"))
            {
                File.WriteAllText("Output.txt", string.Empty);
            }

            var totallength = 0.0;

            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);

                var sizeFile = fileInfo.Length / 1048576.0;

                totallength += sizeFile;
            }

            Console.WriteLine("{0:F2} Megabytes", totallength);

            File.AppendAllText("Output.txt", totallength + Environment.NewLine);
        }
    }
}
