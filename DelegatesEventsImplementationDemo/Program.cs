using System;

namespace DelegatesEventsImplementationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Publisher
            EvsLahoreNotifier notifier=new EvsLahoreNotifier();
            //Subscribers
            DotNet282 dotnet=new DotNet282();
            Xamarin4 xamarin=new Xamarin4();
            SQLServer54 sql=new SQLServer54();

            //Subscribing
            notifier.OnNofication += dotnet.OnNotication;
            notifier.OnNofication += sql.OnNotication;
            notifier.OnNofication += xamarin.OnNotication;

            //Notification to publish
            Notification notification = new Notification
            {
                Name = "Notification",
                Text = "Welcome to Evs Lahore",
                DateTime = DateTime.Now
            };
            
            //Publishing
            notifier.SendNotification(notification);
            Console.ReadKey();
            
            
        }
    }
}