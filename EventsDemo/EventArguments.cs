using System;

namespace EventsDemo
{
    class EventArguments : EventArgs
    {
        private string someValue;

        public string SomeValue
        {
            get { return someValue; }
            set { someValue = value; }
        }
    }
}