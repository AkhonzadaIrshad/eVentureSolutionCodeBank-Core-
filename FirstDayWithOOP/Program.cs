using System;

namespace FirstDayWithOOP
{
    class Student
    {
        private int    rollNumber;
        private string name      ;
        private string fatherName;
     
        public int RollNumber
        {
            set
            {
                if (value > 0 && value < 1000)
                {
                    rollNumber = value;
                }
            }
            get { return rollNumber; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }



    }



    class Program
    {
        static void Main(string[] args)
        {
            Student Ahmed    = new Student();
            Ahmed.RollNumber = 15           ;
            Ahmed.Name       = "Ahmed"      ;
            Ahmed.FatherName = "Ali"        ;

            Student Ali      = new Student();
            Ali.Name         = "Ali"        ;
            Ali.RollNumber   = 16           ;
            Ali.FatherName   = "Usman"      ;

            Console.WriteLine($"Students Records                \n" +
                              $"Name        : {Ahmed.Name}      \n" +
                              $"FatherName  : {Ahmed.FatherName}\n" +
                              $"-----------------               \n" +
                              $"Name        : {Ali.Name}        \n" +
                              $"Father Name : {Ali.FatherName}  \n" +
                              $"");



            Console.ReadKey();

        }
    }
}