using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatesEventsImplementationDemo
{
    /// ***************EVENT SUBSCRIBER CLASS******************
    class SQLServer54
    {
        //Notification event handler
        public void OnNotication(object sender, EventArgs args)
        {
            //Casting EventArgs into CustomEventArgs
            Console.WriteLine("       ***** Notification SQL Server (54) *****        \n" +
                              $"     {((CustomEventArgs)args).Notification.Name}      \n" +
                              $"     {((CustomEventArgs)args).Notification.Text}      \n" +
                              $"     {((CustomEventArgs)args).Notification.DateTime}  \n"
                             );
        }
    }
}
