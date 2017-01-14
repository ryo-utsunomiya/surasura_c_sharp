using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ParamsSample.Run();
        }

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

        class ParamsSample
        {
            public static void Run()
            {
                int max = Max(314, 159, 265, 358, 979);
                Console.WriteLine("{0}", max);
            }

            private static int Max(params int[] a)
            {
                int max = a[0];

                for (int i = 0, len = a.Length; i < len; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }

                return max;
            }
        }
    }
}
