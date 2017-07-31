using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstDayWithOO
{
    class Program
    {

       

        static void Main(string[] args)
        {
            int[] rollNo=new int[50];
            string[] name=new string[50];
            string[] fatherName=new string[50];
            string[] phoneNumber=new string[50];

            for (int i = 0; i < 50; i++)
            {

                Console.WriteLine("Enter Your RollNumber ");
                rollNo[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Name ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter Your Father Name ");
                fatherName[i] = Console.ReadLine();
                Console.WriteLine("Enter Your Phone Number ");
                phoneNumber[i] = Console.ReadLine();


            }




            Console.ReadKey();





        }
    }
}
