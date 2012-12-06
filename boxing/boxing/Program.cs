using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl = 5;
            object box = zahl;
            int unboxed = (int)box;

            Console.WriteLine(unboxed.ToString());
            Console.ReadKey();
        }
    }
}
