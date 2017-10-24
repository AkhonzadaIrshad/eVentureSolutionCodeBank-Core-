using System;
using System.Collections.Generic;

namespace DelegatesWith319Demo
{
    class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
    }



    class Program
    {

        //delegate void MyDelegate(string text);
        //public static void Print(string text)
        //{
        //    Console.WriteLine(text);
        //}
        static void Main(string[] args)
        {

            //MyDelegate myDelegate;
            //myDelegate = Print;
            //myDelegate += Print;
            //myDelegate += Print;
            //myDelegate += Print;
            //myDelegate += Print;
            //myDelegate += Print;
            //myDelegate += Print;


            // myDelegate("This is some text");


            //List<Student>students=new List<Student>();

            //Student student=new Student();
            //student.RollNumber = 1;
            //student.Name = "First";

            //students.Add(student);


            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    RollNumber = 17,
                    Name = "Talha"
                },
                new Student()
                {
                    RollNumber = 8,
                    Name = "Ahsan"
                },
                new Student()
                {
                    RollNumber = 15,
                    Name = "Zirgam"
                },
                new Student()
                {
                    RollNumber = 9,
                    Name = "Shehroze"
                },
            };


            Console.WriteLine("Before Sort");
            foreach (Student student in students)
            {
                Console.WriteLine($"Roll Number : {student.RollNumber}\n" +
                                  $"Name        : {student.Name}\n\n");
            }

            Console.WriteLine("After Sort");


            Comparison<Student> comparer;
           // comparer = (x, y) => { return x.RollNumber.CompareTo(y.RollNumber); };
            comparer = (x, y) => x.Name.CompareTo(y.Name);



            students.Sort(comparer);

            foreach (Student student in students)
            {
                Console.WriteLine($"Roll Number : {student.RollNumber}\n" +
                                  $"Name        : {student.Name}\n\n");
            }

            Console.ReadKey();



        }



        //public static int Method(Student X, Student Y)
        //{
        //    return X.RollNumber.CompareTo(Y.RollNumber);
        //}



    }


}
