using System;
using System.Collections.Generic;

namespace PredicateDemo
{
    partial class Program
    {
        class Student:IComparer<Student>
        {


            public int GetBetweenThisDOB(Student student)
            {

                return (int)DateTime.Now.Subtract(student.DateOfBirth).TotalDays / 365;
            }




            private int rollNumber;

            public int RollNumber
            {
                get { return rollNumber; }
                set { rollNumber = value; }
            }

            private string name;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            private DateTime dateOfBirth;

            public DateTime DateOfBirth
            {
                get { return dateOfBirth; }
                set { dateOfBirth = value; }
            }

            public int Compare(Student x, Student y)
            {
                return x.RollNumber.CompareTo(y.RollNumber);
            }
        }
    }
}