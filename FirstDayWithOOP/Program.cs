using System;
namespace FirstDayWithOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student First=new Student();
            //First.Name = "Ahmed";
            //First.FatherName = "Ali";
            //First.Course=new Course();
            //First.Course.Name = ".NET";
            //First.Course.Duration = 4;
            //First.Course.StartingDateTime=DateTime.Now;



            //Console.WriteLine($"Name          : {First.Name                   }\n" +
            //                  $"Father Name   : {First.FatherName             }\n" +
            //                  $"----------Course Details-----------\n" +
            //                  $"Name          : {First.Course.Name            }\n"+
            //                  $"Duration      : {First.Course.Duration        }\n"+
            //                  $"Starting Date : {First.Course.StartingDateTime}" +
            //                  $"");



            //Student Ahmed    = new Student();
            //Ahmed.RollNumber = 15           ;
            //Ahmed.Name       = "Ahmed"      ;
            //Ahmed.FatherName = "Ali"        ;

            //Student Ali      = new Student();
            //Ali.Name         = "Ali"        ;
            //Ali.RollNumber   = 16           ;
            //Ali.FatherName   = "Usman"      ;

            //Console.WriteLine($"Students Records                \n" +
            //                  $"Name        : {Ahmed.Name}      \n" +
            //                  $"FatherName  : {Ahmed.FatherName}\n" +
            //                  $"-----------------               \n" +
            //                  $"Name        : {Ali.Name}        \n" +
            //                  $"Father Name : {Ali.FatherName}  \n" +
            //                  $"");


            //Constructors

            Address address = new Address();


            Student Ahmed = new Student(address);
            Console.WriteLine(Ahmed.Name);


            Console.WriteLine(Ahmed.Course.Name);
            


        



            Console.ReadKey();

        }
    }
}