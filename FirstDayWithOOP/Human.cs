using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDayWithOOP
{
    public class Human
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string fatherName;

        public string FatherName
        {
            get { return fatherName; }
            set { fatherName = value; }
        }


        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }



    }
}
