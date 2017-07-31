using System;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student();

            std1.Fee = 10;
            Student std2 = new Student();
            std2.Fee = 30;

            // int ans = std1.Fee + std2.Fee;
            int ans = std1 + std2;

            Console.ReadKey();
        }
    }
}