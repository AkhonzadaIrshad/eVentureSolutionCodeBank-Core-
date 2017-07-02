using System;
namespace RandomNumberGameWithRecursionDemo
{
    class Program
    {
        static void StartGame(int randomNumber, int userNumber)
        {
            if (userNumber == randomNumber)
            {
                Console.WriteLine("Successfully Guessed ");
            }
            else if (userNumber > randomNumber)
            {
                Console.WriteLine("Your Number is Greater than Random Number");
                int un = Convert.ToInt32(Console.ReadLine());
                //Recursive Call
                StartGame(randomNumber, un);
            }
            else if (userNumber < randomNumber)
            {
                Console.WriteLine("Your Number is Less than Random Number");
                int un = Convert.ToInt32(Console.ReadLine());
                //Recursive Call
                StartGame(randomNumber, un);
            }
        }
        static void Main(string[] args)
        {
            int randomNumber = new Random().Next(1, 10);
            Console.WriteLine("Guess a Number Between 1-10");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            StartGame(randomNumber, userNumber);
            Console.ReadKey();
        }
    }
}