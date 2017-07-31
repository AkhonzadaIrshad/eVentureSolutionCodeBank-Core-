using System;
namespace DelegatesEventsImplementationDemo
{
    /// <summary>
    /// ***************EVENT PUBLISHER CLASS******************
    /// We want to send notifications each batch.
    /// Steps to raise a notifier event:
    /// 1: Define a delegate
    /// 2: Define an event based on that delegate
    /// 3: Raise that event
    /// </summary>

    //Evs Lahore Notifier Responsible Class
    class EvsLahoreNotifier
    {
        //delegate
        internal delegate void NotificationEventHandler(object sender, EventArgs args);
        //event
        public event NotificationEventHandler OnNofication;
        //Method which we are going to call to raise that event
        public void SendNotification(Notification notification)
        {
            //Calling our event raiser method
            Notify(notification);
        }
        //.Net suggest this convention to raise an event
        protected virtual void Notify(Notification notification)
        {
            //Checking if there are no subscriber
            if (OnNofication != null)
            {
                // Raising event with custom arguments
                //this represents the event generator class
                //CustomEventArgs represents an object containing a notification object
                OnNofication(this, new CustomEventArgs { Notification = notification });
            }
        }
    }
}