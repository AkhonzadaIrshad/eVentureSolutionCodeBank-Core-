using System;

namespace WebsiteSubscriberDemo
{
    class Program
    {
    

        static void Main(string[] args)
        {
            Website website=new Website();
            UserOne user=new UserOne();
            UserTwo userandomNumber =new UserTwo();
            UserThree usero =new UserThree();
            website.onNewMail += user.onMailRecived;
            website.onNewMail += userandomNumber.onMailRecived;
            website.onNewMail += usero.onMailRecived;

            website.SendNewMail();
            

            Console.ReadKey();

        }
    }
}