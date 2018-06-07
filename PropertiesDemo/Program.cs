using System;

namespace PropertiesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DummyClass obj = new DummyClass();

            obj.SetName("Evs Lahore");
            Console.WriteLine(obj.GetName());

            DummyClass obj2 = new DummyClass();
            obj2.Name = "Evs Lahore With Property";





            Console.WriteLine(obj2.Name);

            Console.ReadKey();
        }
    }
}