using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ClassContext:DbContext
    {
        public ClassContext():base("name=abc")
        {
            
        }

        public DbSet<MyClass> MyClasses { get; set; }


    }
}
