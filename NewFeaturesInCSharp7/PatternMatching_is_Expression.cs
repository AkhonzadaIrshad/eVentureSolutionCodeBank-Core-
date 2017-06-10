using System;
using System.Collections.Generic;
using System.Text;

namespace NewFeaturesInCSharp7
{
    class PatternMatching_is_Expression
    {
        public static void Main(string[] args)
        {
            object value = "This is A String";
            if (value is string)
            {
                Console.Clear();
                Console.WriteLine("True");             
            }
            else
            {
                Console.Clear();
                Console.WriteLine("False");
            }

            Console.ReadKey();
        }
    }
}
