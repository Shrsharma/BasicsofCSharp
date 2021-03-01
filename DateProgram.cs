using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsofCSharp
{
    class DateProgram
    {
        public static void Do()
        {
            DateTime dt1 = DateTime.Now;
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.ToShortDateString());
            Console.WriteLine(dt1.ToLongDateString());
            Console.WriteLine(dt1.Year);
            Console.WriteLine(dt1.Month);
            Console.WriteLine(dt1.Day);
            Console.WriteLine(dt1.DayOfWeek);
            Console.WriteLine(dt1.AddDays(5));

            Console.WriteLine("\nFormatted custom date");
            Console.WriteLine(dt1.ToString("d"));
            Console.WriteLine(dt1.ToString("D"));
            Console.WriteLine(dt1.ToString("F"));
            Console.WriteLine(dt1.ToString("y"));

            DateTime dt2 = new DateTime(2021, 3, 2, 09, 57, 10);
            TimeSpan time = dt1.Subtract(dt2);
            Console.WriteLine("\nTimespan is {0} hours", time);
        }
    }
}
