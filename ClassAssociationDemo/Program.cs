using System;

namespace ClassAssociationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student
            {
                Id = 2,
                Name = "Hashim",
                Info =
                {
                    Height     = 6.1f,
                    BloodGroup = "O +"
                }
            };

            //Info i=new Info();
            //i.Height=6.1f;
            //i.BloodGroup = "O+";
            //std.Info = i;

            Console.WriteLine(
                std.Id + " " +
                std.Name + " " +
                std.Info.Height + " " +
                std.Info.BloodGroup
                );

            Console.ReadKey();
        }
    }
}