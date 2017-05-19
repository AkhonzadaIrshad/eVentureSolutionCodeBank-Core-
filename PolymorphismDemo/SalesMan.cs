using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismDemo
{
    class SalesMan:Employee
    {
        public override double TellMeYourSalary()
        {
            return Salary;
        }
    }
}
