using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Person();
            var p2 = new Person("john", 18);
            var p3 = new Person { Name = "bob", Age = 30 };
            VarDumper.Dump(p1);
            VarDumper.Dump(p2);
            VarDumper.Dump(p3);
        }
    }
}
