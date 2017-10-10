using System;

namespace CsharpRevision321
{
    class Student
    {
        //fields
        
        private int rollNumber;

        //Properties


        public int RollNumber
        {
            set
            {
                if (value>0)
                {
                    rollNumber = value;
                }
                else
                {
                    Console.WriteLine("Invalid");
                }
                
            }
            get
            {
                return rollNumber;
                
            }
        }


        //Constructor
        //Methods

        public void SetRollNumber(int r)
        {
            rollNumber = r;
        }

        public int GetRollNumber()
        {
            return rollNumber;
        }



        //Destructors
        
    }
}