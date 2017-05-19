using System;
using System.Collections.Generic;

namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 2, b = 3;
            //string x = "somedata", y = "data";
            //Console.WriteLine(new Dummy<String>().Compare(x, y));
            //Console.WriteLine(new Dummy<int>().Compare(a, b));

            List<SomeClass<int>> i = new List<SomeClass<int>>()
            {
                new SomeClass<int>()
                {
                    Somedata = 6
                },
                new SomeClass<int>()
                {
                    Somedata = 8
                }
            };


            i.Add(new SomeClass<int>()
            {
                Somedata = 6,
            });



            SomeClass<string> obj = new SomeClass<string>();
            obj.Somedata = "Hashim";
            Console.WriteLine(obj.Somedata);
            SomeClass<int> obj2 = new SomeClass<int>();
            obj2.Somedata = 5;
            Console.WriteLine(obj2.Somedata);


            Console.ReadKey();
        }
    }
}