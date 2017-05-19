using System;
using System.Collections.Generic;
using System.Text;

namespace PropertiesDemo
{
   public class DummyClass
    {
        private string name;

        //setter 
        public void SetName(string nm)
        {
            name = nm;
        }
        //getter 
        public string GetName()
        {
            return name;
        }


        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
