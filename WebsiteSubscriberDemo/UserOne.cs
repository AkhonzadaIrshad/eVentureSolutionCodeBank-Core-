using System;

namespace WebsiteSubscriberDemo
{
    class UserOne
    {
        public void onMailRecived(object sender, EventArgs args)
        {
            Console.WriteLine("Im User One");
        }
    }
}