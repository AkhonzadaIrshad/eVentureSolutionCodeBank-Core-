using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    class DummyClass
    {

        public event EventHandler OnPropertyChange;

        private string dummyValue;

        public string DummyValue
        {
            get { return dummyValue; }
            set
            {
                dummyValue = value;
                if (value.Equals("EVS"))
                {
                    
                    OnPropertyChange(this,new EventArguments(){SomeValue = "SomeData"});

                }

            }
        }


    }
}
