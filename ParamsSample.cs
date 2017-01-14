using System;

namespace ConsoleApplication
{
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