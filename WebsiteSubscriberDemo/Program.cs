using System;

namespace WebsiteSubscriberDemo
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Website website=new Website();
            User user=new User();
            NewUser usern=new NewUser();
            OtherUser usero=new OtherUser();
            website.onNewMail += user.onMailRecived;
            website.onNewMail += usern.onMailRecived;
            website.onNewMail += usero.onMailRecived;

            website.SendNewMail();
            

            Console.ReadKey();

        }
    }
}