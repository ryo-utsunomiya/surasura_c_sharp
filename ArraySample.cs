using System;

namespace ConsoleApplication
{
    class ArraySample
    {
        public static void Run()
        {
            var x = new[] { 9, 15, 32 };
            x[1] = 4;

            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);
        }
    }

}