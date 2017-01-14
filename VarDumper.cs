using System;
using System.Reflection;

namespace ConsoleApplication
{
    public static class VarDumper
    {
        public static void Dump(object obj)
        {
            Console.WriteLine(obj.GetType().Name);

            foreach (var info in obj.GetType().GetFields())
            {
                Console.WriteLine(
                    string.Format("{0}={1}", info.Name, info.GetValue(obj).ToString())
                );
            }
            
            foreach (var info in obj.GetType().GetProperties())
            {
                Console.WriteLine(
                    string.Format("{0}={1}", info.Name, info.GetValue(obj).ToString())
                );
            }

            Console.WriteLine();
        }
    }
}
