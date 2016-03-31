using System;
using System.Collections.Generic;
using System.IO;

namespace FileNamesHistogram
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathDir = @"../../TestDirectory";
            Dictionary<string, int> dict = new Dictionary<string, int>();
            GetFiles(pathDir, dict);
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
        }

        /// <summary>
        /// Recursive method for looking and counting files
        /// </summary>
        /// <param name="path"></param>
        /// <param name="dict"></param>
        private static void GetFiles(string path, Dictionary<string,int> dict)
        {
            
            DirectoryInfo[] dir = new DirectoryInfo(path).GetDirectories();
            FileInfo[] fileInfo = new DirectoryInfo(path).GetFiles();

            if (fileInfo != null)
            {
                foreach (var files in fileInfo)
                {
                    if (dict.ContainsKey(files.Name))
                    {
                        dict[files.Name]++;
                    }
                    else
                    {
                        dict.Add(files.Name, 1);
                    }
                }
            }

            if (dir != null)
            {
                foreach (var dirInfo in dir)
                {
                    GetFiles(dirInfo.FullName, dict);
                }
            }
        }
    }
}
