using System;

namespace DelegatesEventsImplementationDemo
{
    /// ***************EVENT SUBSCRIBER CLASS******************
    class Xamarin4
    {
        //Notification event handler
        public void OnNotication(object sender, EventArgs args)
        {
            //Casting EventArgs into CustomEventArgs
            Console.WriteLine("         ***** Notification Xamarin (4) *****          \n" +
                              $"     {((CustomEventArgs)args).Notification.Name}      \n" +
                              $"     {((CustomEventArgs)args).Notification.Text}      \n" +
                              $"     {((CustomEventArgs)args).Notification.DateTime}  \n");
        }
    }
}