using System;
using System.Collections.Generic;
using System.Text;

namespace BasicsofCSharp
{
    class PrimitiveTypes
    {
        public static void Do()
        {
            bool xb = true;
            int xint = 100;
            long xlong = 1000000000000000;
            short xshort = 10;
            float xfloat = 10.05f;
            double xdouble = 10001.897;
            decimal xdecimal = 87.9M;
            string xstring = "Name";
            char xchar = 'a';
            object xobject = new object();

            Console.WriteLine(xb);
            Console.WriteLine(xint);
            Console.WriteLine(xlong);
            Console.WriteLine(xshort);
            Console.WriteLine(xfloat);
            Console.WriteLine(xdouble);
            Console.WriteLine(xdecimal);
            Console.WriteLine(xstring);
            Console.WriteLine(xchar);



        }
    }
}
