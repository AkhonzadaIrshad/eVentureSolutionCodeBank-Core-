
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTEST
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student()
            {
                Name = "ABC"
            };

            studentrecordsEntities context =new studentrecordsEntities();
            using (context)
            {
                context.Students.Add(student);
                context.SaveChanges();


            }



            Console.WriteLine();
        }
    }
}
