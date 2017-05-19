using System;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            DummyClass d = new DummyClass();


            Console.WriteLine($"Object No : {d.CountIt()}");
            


            DummyClass C = new DummyClass();
            Console.WriteLine($"Object No : {C.CountIt()}");
            //d.FirstName = "Evs Lahore";
            //Console.WriteLine(C.FirstName);
            Console.ReadKey();
        }
    }

    
}