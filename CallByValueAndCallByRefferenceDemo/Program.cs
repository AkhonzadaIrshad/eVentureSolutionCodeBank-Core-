using System;

namespace CallByValueAndCallByReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pass by Value

            int valueOne = 10;
            Console.WriteLine("     - - - - Pass By Value - - - -      \n\n" +
                             $"Before Passing To Method : {valueOne}     ");
            MethodByValue(valueOne);
            Console.WriteLine($"After  Passing To Method : {valueOne}    " +
                              "\n\n\n");

            //Pass By Reference with ref
            int valueTwo = 10;
            Console.WriteLine("- - - - Pass By Reference (ref) - - - - \n\n" +
                             $"Before Passing To Method : {valueTwo}    ");
            MethodByReferenceForRef(ref valueTwo);
            Console.WriteLine($"After  Passing To Method : {valueTwo}    " +
                              "\n\n\n");

            //Pass By Reference with out
            int valueThree = 20;
            Console.WriteLine(" - - - - Pass By Reference (out) - - - - \n\n" +
                             $"Before Passing To Method : {valueThree}   ");
            MethodByReferenceForOut(out valueThree);
            Console.WriteLine($"After  Passing To Method : {valueThree}   " +
                              "\n\n\n");

            Console.ReadKey();
        }
        //Pass By Value Method
        static void MethodByValue(int value)
        {
            Console.WriteLine($"Output From Method       : {value += 10}");
        }
        //Pass By Reference with Ref Method
        static void MethodByReferenceForRef(ref int value)
        {
            Console.WriteLine($"Output From Method       : {value += 10}");
        }
        //Pass By Reference with Out Method
        static void MethodByReferenceForOut(out int value)
        {
            //Must Assign a value before using it
            value = 10;
            Console.WriteLine($"Output From Method       : {value}");
        }
    }
}