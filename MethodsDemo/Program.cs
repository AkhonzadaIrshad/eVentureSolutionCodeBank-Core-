using System;

namespace MethodsDemo
{
    class Program
    {

        //static void DemoMethod()//Method Without returning Anything
        // {

        //     Console.WriteLine("Hey you called Me ? ");

        // }

        //static void DemoMethod(int one,int two)
        //{

        //    Console.WriteLine($"Hey you called Me ? your Numbers Are : {one} {two}");


        //}


        //static void AdditionMethod(int one, int two)
        //{

        //    Console.WriteLine($"Addition : {one+two}");


        //}

        static int  AdditionMethod(int one, int two)
        {

            return one + two;


        }
        static void Main(string[] args)
        {

            int a, b;

            Console.WriteLine("Please Enter Number One");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Number Two");
            b = Convert.ToInt32(Console.ReadLine());


            // DemoMethod();

            // DemoMethod(a,b);

            // AdditionMethod(a,b);

            Console.WriteLine($"Addition : {AdditionMethod(a, b) + 50}");



            Console.ReadKey();




        }
    }
}