using System;
using System.Collections.Generic;
using System.Text;

namespace PolymorphismDemo
{
    class Peon:Employee
    {
        public override double TellMeYourSalary()
        {
            return Salary;
        }
    }
}
