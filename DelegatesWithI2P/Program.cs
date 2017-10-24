using System;

namespace DelegatesWithI2P
{
    class Program
    {


        delegate void FirstDelegate(); 

        public static void Method()
        {
            Console.WriteLine("Hello");
        }




        static void Main(string[] args)
        {

            FirstDelegate first;

            first = Method;
            first += Method;
            first += () => { Console.WriteLine("Hello From Labmda Expression"); };

            first();


            Console.ReadKey();
        }
    }
}
