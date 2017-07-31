namespace OperatorOverloading
{
    class Student
    {
        private int fee;

        public int Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public static int operator +(Student s1, Student s2)
        {
            return s1.Fee + s2.Fee;
        }
    }
}