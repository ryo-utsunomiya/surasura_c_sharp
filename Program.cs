using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Func<int, int, int> f = Add;
            Console.WriteLine(f(1,2));
        }

        static int Add(int x, int y)
        {
            return x + y;
        }
    }
}
