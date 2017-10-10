using System;
using System.Collections.Generic;
using System.Linq;

namespace SortObjectsViaComparisonDelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student()
                {
                    RollNumber = 111,
                    DateOfBirth = new DateTime(1996,8,11),
                    Name = "Irshad"
                },
                new Student()
                {
                    RollNumber = 222,
                    DateOfBirth = new DateTime(1998,2,1),
                    Name = "Faizan"
                },
                new Student()
                {
                    RollNumber = 333,
                    DateOfBirth = new DateTime(1988,1,5),
                    Name = "Zeeshan"
                },
            };


            Comparison<Student> comparison = (One, Two) =>
            {
                return One.Name.CompareTo(Two.Name);
            };

            students.Sort(comparison);
            foreach (Student student in students)
            {
                Console.WriteLine($"Roll Number   : {student.RollNumber               }\n" +
                                  $"Name          : {student.Name                     }\n" +
                                  $"Date Of Birth : {student.DateOfBirth.ToString("f")}\n");
            }

            Console.ReadKey();
        }
    }
}
