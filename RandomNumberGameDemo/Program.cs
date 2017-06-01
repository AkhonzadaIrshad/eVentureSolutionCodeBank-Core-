using System;

namespace RandomNumberGameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Random Class Object to generate a Random Number
            Random random = new Random();
            //Generating Random Number
            int randomNumber = random.Next(1, 10);
            //User Guess 
            int userNumber;
            Console.WriteLine("Guess a Number Between 1-10");
            do
            {
                //Getting User Number
                userNumber = Convert.ToInt32(Console.ReadLine());
                if (userNumber>randomNumber)
                {
                    Console.WriteLine("Your Number is greater than Random Number");
                }
                else if (userNumber<randomNumber)
                {
                    Console.WriteLine("Your Number is smaller than Random Number");
                }
                else 
                {
                    Console.WriteLine("You Won :)");
                }
            } while (userNumber != randomNumber);
            Console.ReadKey();
        }
    }
}