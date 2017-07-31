using System;

namespace WebsiteSubscriberDemo
{
    class Website
    {
        //1- Create a delegate
        //2- Create an event based on that delegate
        //3- Raise that event

        public delegate void MailEventHandler(object sender, EventArgs args);

        public event MailEventHandler onNewMail;

        public void SendNewMail()
        {
            SentMail();
        }

        protected virtual void SentMail()
        {
            onNewMail(this, EventArgs.Empty);
        }
    }
}