namespace PolymorphismDemo
{
    abstract class Employee
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public abstract double TellMeYourSalary();
    }
}