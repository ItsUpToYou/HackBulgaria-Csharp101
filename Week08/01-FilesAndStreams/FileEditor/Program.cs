using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the filename to edit");
            string fileName = Console.ReadLine();

            while (!File.Exists(fileName))
            {
                Console.WriteLine("The file {0} does not exist", fileName);
                Console.WriteLine("Enter again your fileName to edit");
                fileName = Console.ReadLine();
            }

            Console.WriteLine("List of commands:");
            Console.WriteLine();
            Console.WriteLine("list - list the contents of the file");
            Console.WriteLine("clear - clear the contents of the file");
            Console.WriteLine("append - append a new line to the file");
            Console.WriteLine("append<text> - append text to the file");
            Console.WriteLine("linecount - number of the lines in the file");
            Console.WriteLine("exit - exits editor");

            string input = string.Empty;

            while (input != "exit")
            {
                input = Console.ReadLine();
                string[] command = input.Split();

                switch (command[0].ToLower())
                {
                    case "list":
                        Console.WriteLine(File.ReadAllText(fileName));
                        break;
                    case "clear":
                        File.WriteAllText(fileName, string.Empty);
                        Console.WriteLine("File is cleared");
                        break;
                    case "appendline":
                        File.AppendAllText(fileName, Environment.NewLine);
                        Console.WriteLine("appendLine is added");
                        break;
                    case "append":
                        File.AppendAllText(fileName, string.Join(" ", command.Skip(1)));
                        break;
                    case "linecount":
                        Console.WriteLine(File.ReadLines(fileName).Count());
                        break;
                    case "Quit!":
                        Console.WriteLine(input);
                        break;

                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
                Console.WriteLine();
            }


        }
    }
}
