using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ArraySample();
        }

        private static void ArraySample()
        {
            var x = new[] { 9, 15, 32 };
            x[1] = 4;

            Console.WriteLine(x[0]);
            Console.WriteLine(x[1]);
            Console.WriteLine(x[2]);

        }
    }
}
