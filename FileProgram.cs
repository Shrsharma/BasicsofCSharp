using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BasicsofCSharp
{
    class FileProgram
    {
        public static void Do()
        {
            //WriteText();
            //ReadText();
            WriteLine();
            ReadLine();
        }

        private static void WriteLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("\nFile exists");
            }
            else
            {
                Console.WriteLine("\nFile doesn't exist");
            }

            StreamWriter wrt = File.CreateText(filename);
            wrt.WriteLine("This is line one");
            wrt.WriteLine("This is line two");
            wrt.WriteLine("This is line three");
            wrt.WriteLine("This is line four");
            wrt.Close();
            Console.WriteLine("\nContent lines have been added into file");
        }

        private static void ReadLine()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\dataLine.txt";
            if (File.Exists(filename))
            {
                Console.WriteLine("\nFile exists");
                string[] contents = File.ReadAllLines(filename);
                foreach (var content in contents)
                {
                    Console.WriteLine(content);
                }
            }
            else
            {
                Console.WriteLine("\nFile doesn't exist");
            }
        }
        private static void WriteText()
        {
            string dir = Directory.GetCurrentDirectory();
            string filename = dir + "\\data.txt";
            Console.WriteLine(filename);
            if (!File.Exists(filename))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");
            }
            string content = "This is a test content";
            File.WriteAllText(filename, content);
            Console.WriteLine("Content is written into file");
        }

        private static void ReadText()
        {
            string dir = Directory.GetCurrentDirectory();
            string path = dir + "\\Content.txt";
            Console.WriteLine(path);
            if (!File.Exists(path))
            {
                Console.WriteLine("File doesn't exist");
            }
            else
            {
                Console.WriteLine("File exists");
                string content = File.ReadAllText(path);
                Console.WriteLine(content);
            }
        }
    }
}