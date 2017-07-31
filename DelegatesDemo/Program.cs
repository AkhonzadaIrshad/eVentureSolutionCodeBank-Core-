using System;

namespace DelegatesDemo
{
    class Program
    {
        delegate void DemoDelegate(string value);

        static void Print(string name)
        {
            Console.WriteLine($"Your Name {name}");
        }
        static void OtherPrint(string name)
        {
            Console.WriteLine($"Your Other Name {name}");
        }
        //static void Main(string[] args)
        //{
        //   // Console.WriteLine("Hello World!");
        //   //Print("Irshad");

        //    DemoDelegate demoDelegate = Print;
        //    demoDelegate += OtherPrint;

        //    demoDelegate("Evs Lahore");

        //    Console.ReadKey();

        //}
    }
}