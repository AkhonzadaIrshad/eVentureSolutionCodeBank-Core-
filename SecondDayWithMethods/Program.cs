using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDayWithMethods
{
    class Program
    {
       static int Addition(int a, int b)
        {
            return a + b;
        }

        static bool AreEqual(int a, int b)
        {
            return a==b?true:false;
        }


        static void Main(string[] args)
        {
          //int c= Addition(2,4)+100;
           Calculator calculator=new Calculator();
            string valueOne = "This is Evs Lahore";
            string ValueTwo = "This is Another EVS";
            calculator.PrintMessage(valueOne,ValueTwo);

            Console.ReadKey();
        }
    }

    class Calculator
    {
        public void PrintMessage(string TextOne,string TextTwo)
        {
            if (TextOne.Equals("EVS"))
            {
                Console.WriteLine($"Welcome To {TextOne} Lahore");
            }
            else if (TextOne.Contains("Evs"))
            {
                Console.WriteLine($"Message {TextOne}");

            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        

    }
}
