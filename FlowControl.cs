using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsofCSharp
{
    class FlowControl
    {

        public static void Do()
        {
            int a = 150;
            if (a==100)
            {
                Console.WriteLine("The value is 100");
            }
            else
            {
                Console.WriteLine("The value is {0}", a);
            }

            //While Loop
            Console.WriteLine("\nWhile Loop:");
            var counter = 0;
            while (counter < 10)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //For Loop
            Console.WriteLine("\nFor Loop:");
            for (int i = counter; i < 20; i++)
            {
                counter = i;
                Console.WriteLine(counter);
            }

            //Do-While Loop
            Console.WriteLine("\nDo-While Loop:");
            do
            {
                Console.WriteLine(counter);
                counter++;

            } while (counter < 30);

            //For Each

            int[] array = { 10, 20, 30, 40, 50 };
            Console.WriteLine("\nFor each loop");
            foreach (int element in array)
            {
                Console.WriteLine(element);
            }

        }
    }
}
