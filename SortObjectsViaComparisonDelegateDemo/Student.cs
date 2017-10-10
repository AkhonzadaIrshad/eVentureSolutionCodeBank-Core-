using System;

namespace SortObjectsViaComparisonDelegateDemo
{
    class Student
    {
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

    }
}