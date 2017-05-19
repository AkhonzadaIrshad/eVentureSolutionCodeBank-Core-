using System;

namespace MethodsWithClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.WriteLine("Please Enter Number One");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number Two");
            b = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator();


            // Console.WriteLine("Addition : {0} ",Calculator.AdditionMethod(a, b));// Static Method
            Console.WriteLine("\nAddition : {0} ",calculator.AdditionMethod(a, b));//Non Static Method
           



            Console.ReadKey();

        }
    }
}