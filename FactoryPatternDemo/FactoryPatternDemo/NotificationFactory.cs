using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternDemo
{
    public interface INotificationFactory
    {
        INotification CreateNotification(string type);
    }

    public class NotificationFactory : INotificationFactory
    {
        public  INotification CreateNotification(string type)
        {
            switch (type.ToLower())
            {
                case "email":
                    return new EmailNotification();
                case "sms":
                    return new SMSNotification();
                case "push":
                    return new PushNotification();
                default:
                    throw new ArgumentException("Invalid notification type");
            }
        }
    }
}
