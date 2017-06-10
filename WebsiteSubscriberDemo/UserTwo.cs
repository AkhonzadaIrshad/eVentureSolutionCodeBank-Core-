using System;

namespace WebsiteSubscriberDemo
{
    class UserTwo
    {
        public void onMailRecived(object sender, EventArgs args)
        {
            Console.WriteLine("Im User Two");
        }
    }
}