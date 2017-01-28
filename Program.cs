using System;

namespace ConsoleApplication
{
    delegate void ShowMessage();

    public class Program
    {
        public static void Main(string[] args)
        {
            var p1 = new Person("john");
            var p2 = new Person("paul");

            var show = new ShowMessage(p1.ShowName);
            show += new ShowMessage(p2.ShowName);
            show += new ShowMessage(A);
            
            show();
        }

        static void A()
        {
            Console.WriteLine("A is called");
        }
    }
}
