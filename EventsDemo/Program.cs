using System;

namespace EventsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            DummyClass dummy = new DummyClass();
            dummy.OnPropertyChange += Dummy_OnPropertyChange;

            dummy.DummyValue = "EVS";

            Console.ReadKey();
        }

        private static void Dummy_OnPropertyChange(object sender, EventArgs e)
        {
            Console.WriteLine($"New Value {((DummyClass)sender).DummyValue}");
            Console.WriteLine($"Data from Event Args Value {((EventArguments)e).SomeValue}");
        }
    }
}