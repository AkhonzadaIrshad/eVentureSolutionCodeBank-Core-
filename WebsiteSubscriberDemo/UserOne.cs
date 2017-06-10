using System;
using System.Collections.Generic;
using System.Text;

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
