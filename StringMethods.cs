using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsofCSharp
{
    class StringMethods
    {
        public static void Do()
        {
            string Mary = "Mary had a little lamb.";
            Console.WriteLine("\nOriginal string:"+ Mary);
            Console.WriteLine("\nClone of stirng:"+ Mary.Clone());
            Console.WriteLine("\nComparing strings:{0}", Mary.CompareTo("Mary had a big lamb"));
            Console.WriteLine("\nCharacters in a string:{0}", Mary.Contains("had"));
            Console.WriteLine("\nString ends with:{0}", Mary.EndsWith("xyz"));
            Console.WriteLine("\nLowercase:" + Mary.ToLower());
            Console.WriteLine("\nUppercase:" + Mary.ToUpper());

            Console.WriteLine("\nInsert string:" + Mary.Insert(4, " and Jack"));
            Console.WriteLine("\nSplitting String:");
            string[] parts = Mary.Split(" ");
            foreach (string p in parts)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("\nString Builder:");
            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < 10; i++)
            {
                sb.Append(i.ToString() + " ");
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
