using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    class EventArguments:EventArgs
    {
        private string someValue;

        public string SomeValue
        {
            get { return someValue; }
            set { someValue = value; }
        }



    }
}
