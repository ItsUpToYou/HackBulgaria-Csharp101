using System;
using System.Collections.Generic;
using System.IO;

namespace DirectoryTraversal
{
    class Program
    {
        /*
        Write a method which iterates through the contents of a directory and the contents of all its subdirectories. 
        Use the yield operator to return the name of each entry and sub-entry.

        IEnumerable<string> IterateDirectory(DirectoryInfo dir)

        How to create DirectoryInfo
        DirectoryInfo methods
Hint: use the GetDirectories method to get all subdirectories and the GetFiles method to get all files in a directory.
        */

        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Program Files\Internet Explorer");

            foreach (var item in IterateDirectory(dirInfo))
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable<string> IterateDirectory(DirectoryInfo dir)
        {
            var files = dir.GetFiles();
            var dirs = dir.GetDirectories();

            foreach (var cDir in dirs)
            {
                foreach (var name in IterateDirectory(cDir))
                {
                    yield return name;
                }
            }

            foreach (var file in files)
            {
                yield return file.Name;
            }
        }
    }
}
