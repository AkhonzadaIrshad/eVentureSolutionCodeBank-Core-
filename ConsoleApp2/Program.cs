using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    class MyClass
    {
        public int Id { get; set; }
        public string Property { get; set; }
        
        
    }


    class Program
    {
        static void Main(string[] args)
        {


            ClassContext context=new ClassContext();
            using (context)
            {
                context.MyClasses.ToList();
            }

            Console.WriteLine("dONE");
        }
    }
}
