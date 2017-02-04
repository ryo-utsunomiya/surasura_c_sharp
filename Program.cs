using System;

namespace ConsoleApplication
{
    delegate void ShowMessage();

    public class Program
    {
        public static void Main(string[] args)
        {
            const int SIZE = 5;
            var si = new Stack<int>(SIZE);
            var sd = new Stack<double>(SIZE);

            for (int i = 1; i <= SIZE; ++i)
            {
                si.Push(i);
                sd.Push(1.0/i);
            }

            while (si.Size != 0)
            {
                Console.WriteLine("1/{0} = {1}", si.Pop(), sd.Pop());
            }
        }
    }
}
