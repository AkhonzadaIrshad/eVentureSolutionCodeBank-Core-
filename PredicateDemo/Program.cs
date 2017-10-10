using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDemo
{
    partial class Program
    {


        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    Name = "AAA",
                    RollNumber = 555,
                    DateOfBirth = new DateTime(1996, 8, 11)
                },
                new Student()
                {
                    Name = "BBB",
                    RollNumber = 222,
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Student()
                {
                    Name = "CCC",
                    RollNumber = 333,
                    DateOfBirth = new DateTime(2000, 12, 13)
                },
                new Student()
                {
                    Name = "DDD",
                    RollNumber = 111,
                    DateOfBirth = new DateTime(1994, 2, 1)
                },
            };


            Predicate<Student> predicate;
            predicate = student => { return student.GetBetweenThisDOB(student) > 19; };

            IComparer<Student> comparer=new Student();
            List<Student> AllStudents = students.FindAll(predicate);
            AllStudents.Sort(comparer);

           



            foreach (Student student in AllStudents)
            {
                Console.WriteLine($"Name         : {student.Name                     }\n" +
                                  $"Roll Number  : {student.RollNumber               }\n" +
                                  $"Date Of Birt : {student.DateOfBirth.ToString("f")}\n");

            }
         
            
            Console.ReadKey();
        }
    }
}