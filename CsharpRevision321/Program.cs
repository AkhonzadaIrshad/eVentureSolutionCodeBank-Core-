
using System;

namespace CsharpRevision321
{

    class Program
    {


        public static void FirstMethod()
        {
            Console.WriteLine("Hi from First Method");
        }

        public static void Main(string[] args)
        {



            //Sequencial Programming - Procedural Programming

            //Print Statement
            ///Console.WriteLine("Our First Application");



            //Data Types
            //1: Value Types

            //Numeric 
            //short 16bit
            //int 32bit
            //long 64bit

            //short One = 123;
            //int Two = 121;



            //Casting 
            //Implicit
            // Two = One;

            //Explicit

            //One = (short)Two;
            //One = Convert.ToInt16(Two);





            //Number (Precise)
            //float
            //double
            //decimal


            //Textual Information
            //char  _char= 'A';
            //string _string= "AA";





            //Input Statement

            //string Name;


            //Console.WriteLine("Enter Your Name");
            //Name=Console.ReadLine();

            //int Age;
            //Console.WriteLine("Enter Your Age");

            //Age=Convert.ToInt32(Console.ReadLine());



            //Arrays

            //int[] FirstArray=new int[15];

            // string[] SecondArray=new string[45];





            //Method Calling

            //FirstMethod();


            //Objects
            Student std=new Student();
            // std.SetRollNumber(123);

            //Console.WriteLine(std.GetRollNumber());


                std.RollNumber = 0;





            Console.WriteLine(std.RollNumber);


            //Pause
            Console.ReadKey();



        }
    }
}