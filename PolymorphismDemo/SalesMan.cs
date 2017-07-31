namespace PolymorphismDemo
{
    class SalesMan : Employee
    {
        public override double TellMeYourSalary()
        {
            return Salary;
        }
    }
}