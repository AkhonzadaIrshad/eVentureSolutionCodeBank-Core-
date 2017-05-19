using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesDemo
{
    class DemoTwo
    {



        delegate void OurDelegate(int c, int d);

        static void Main(string[] args)
        {

            //OurDelegate test=new OurDelegate(SomeFunction);
            OurDelegate test2;
            test2 = SomeFunction;
            test2 += SomeOtherFunction;
            test2(8, 9);
            Console.ReadKey();


        }


        static void SomeFunction(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void SomeOtherFunction(int a, int b)
        {
            Console.WriteLine(a - b);
        }
    }
}
