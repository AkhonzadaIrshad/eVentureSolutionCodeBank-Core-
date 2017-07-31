using System;
using System.Collections.Generic;

namespace StructAndAssociation
{
    struct MyStruct
    {
        public int Abc;
    }

    class Program
    {

       

        static void Main(string[] args)
        {
            Teacher t=new Teacher();
            t.Name = "ABC";
            t.Course.Name = "dotNet";

            Console.WriteLine($"{t.Name}");
            Console.WriteLine($"{t.Course.Name}");

            Student student=new Student()
            {
                Name = "ALi"
            };
            t.Student = student;



            Console.WriteLine($"{t.Name}");
            Console.WriteLine($"{t.Course.Name}");
            Console.WriteLine($"{t.Course.Name}");

            Console.ReadKey();

        }
    }

    class Teacher
    {

        public Teacher()
        {
            Course =new Course();
        }

        public Course Course { get; set; }

        public string Name { get; set; }
        public Student Student { get; set; }
    }

   
    class Student
    {
        public string Name { get; set; }

    }


    class Course
    {
        public string Name { get; set; }
        
    }
}

