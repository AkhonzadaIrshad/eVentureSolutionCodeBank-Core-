using System;

namespace DelegatesEventsImplementationDemo
{
    //Data related to a notification to be sent
    class Notification
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string text;

        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        private DateTime dateTime;

        public DateTime DateTime
        {
            get { return dateTime; }
            set { dateTime = value; }
        }
    }
}