
using System;
namespace MyFirstDayWithC_Sharp
{

    class DummyClass
    {
        static void Main(string[] args)
        {
            ///value Types simple number data
            //short 
            //int 
            //long
            //value Types for Precise Data
            //float
            //double
            //decimal

            //struct

            //Reference Types
            //var;
            //object;
            //dynamic;
            //class

            short _short = 10;
            int _int = 5;

            //implicit
            _int = _short;
            //explicit 1
            _short = (short)_int;
            //explicit 2
            _short = Convert.ToInt16(_int);


            //Textual Data

            string _string = "EVS Lahore";
            //char _char = 'A';
            //Boxing
            _string = _int.ToString();
            //Unboxing
            _int = Convert.ToInt32(_string);

            //Console.WriteLine("Enter a Number");
            //_int = Convert.ToInt32(Console.ReadLine());
            //_string = Console.ReadLine();


            //Date Time
            //DateTime dateandTime;
            //dateandTime = DateTime.Now;


            //Concatination
            //Console.WriteLine($"Date Time is : {dateandTime.ToString()}");
            //Console.WriteLine("Values is : " + _int);
            //Console.WriteLine("Values is : {0}", value);
            //Console.WriteLine($"Values is : {value}");
            //// Console.WriteLine("Hello .NET ");


            //Conditional Structures
            //int a = 30;
            //int b = 20;
            //int c;


            //If
            //if (a > b)
            //


            //if (b>a)
            //{
            //    c = b;
            //}
            //else
            //{
            //    c = 0;
            //}


            //Switch Case

            //int a;
            //a = Convert.ToInt32(Console.ReadLine());
            //switch (a)
            //{
            //    case 1:
            //        {
            //            Console.WriteLine("A is 1");
            //            break;

            //        }
            //    case 2:
            //        {
            //            Console.WriteLine("A is 2");
            //            break;
            //        }
            //    default:
            //        {
            //            Console.WriteLine("A is 1");
            //            break;
            //        }

            //}





          //  Console.WriteLine($"The Value of c is : {a}");





            //Control Structures
            //For Loop

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Hello World");
            //}

            //While Loop 

            int a = 20;
            int b = 20;

            while (a<b)
            {
                Console.WriteLine("A is Smaller than B");
                a++;
            }

            //Do While 
            do
            {
                Console.WriteLine("A is Smaller than B");
                a++;

            } while (a < b);

            Console.WriteLine("Press Any Key ...");
            Console.ReadKey();
        }
    }
}