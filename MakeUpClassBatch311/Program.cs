using System;

namespace MakeUpClassBatch311
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student student=new Student();
            //// student.Name = "Evs Lahore";
            // Console.WriteLine(student.Name);
            // string n = student.Name;
            Person p = new Person();
            p.Address.StreetAddress = "440 A";
            Console.WriteLine("Street Address {0}", p.Address.StreetAddress);
            City city = new City();
            city.Name = "Lahore";
            p.Address.City = city;

            Console.WriteLine("City  {0}", p.Address.City.Name);

            Console.ReadKey();
        }
    }
}