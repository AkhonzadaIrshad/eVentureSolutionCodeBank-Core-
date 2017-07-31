using System;
using System.Collections.Generic;

namespace PolymorphismDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>()
            {
                new Peon()
                {
                    Salary      = 12000      ,
                    Designation = "Peon"     ,
                    Name        = "aaaa"     ,
                    Id          = 1122
                }                            ,
                new Peon()
                {
                    Salary      = 12000      ,
                    Designation = "Peon"     ,
                    Name        = "bbbb"     ,
                    Id          = 1123
                }                            ,
                new Peon()
                {
                    Salary      = 12000      ,
                    Designation = "Peon"     ,
                    Name        = "cccc"     ,
                    Id          = 1124
                }                            ,
                new Manager()
                {
                    Designation = "Manager"  ,
                    Salary      = 80000      ,
                    Id          = 3322       ,
                    Name        = "abc"      ,
                    Email       = "abc@y.com"
                }                            ,
                new SalesMan()
                {
                    Salary      = 25000      ,
                    Designation = "Sales Man",
                    Name        = "xyz"      ,
                    Id          = 4422
                }                            ,
                new SalesMan()
                {
                    Salary      = 25000      ,
                    Designation = "Sales Man",
                    Name        = "lmn"      ,
                    Id          = 4423
                }
            };

            foreach (Employee employee in employeeList)
            {
                Console.WriteLine($"Name        : {employee.Name              }\n" +
                                  $"Designation : {employee.Designation       }\n" +
                                  $"Salary      : {employee.TellMeYourSalary()}\n"
                                  );
            }
            Console.ReadKey();
        }
    }
}