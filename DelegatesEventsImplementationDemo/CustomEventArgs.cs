using System;

namespace DelegatesEventsImplementationDemo
{
    //custom event argument to attach our notification
    internal class CustomEventArgs : EventArgs
    {
        private Notification notification;

        public Notification Notification
        {
            get { return notification; }
            set { notification = value; }
        }

    }
}