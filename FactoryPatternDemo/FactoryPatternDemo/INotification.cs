using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public interface INotification
    {
        void SendNotification(string message);

    }

    public class EmailNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Email Notification: {message}");
        }
    }
    
    public class SMSNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"SMS Notification: {message}");
        }
    }

    public class PushNotification : INotification
    {
        public void SendNotification(string message)
        {
            Console.WriteLine($"Push Notification: {message}");
        }   
    }
    
}
