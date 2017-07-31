namespace PolymorphismDemo
{
    class Peon : Employee
    {
        public override double TellMeYourSalary()
        {
            return Salary;
        }
    }
}