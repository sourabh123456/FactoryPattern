using System;

namespace FactoryPatternDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            INotification notification = new NotificationFacotry().CreateNotification("email");
            notification.SendNotification("This is email notification");

            INotification smsNotification = new NotificationFacotry().CreateNotification("sms");
            notification.SendNotification("This is SMS notification");

            INotification pushNotification = new NotificationFacotry().CreateNotification("push");
            notification.SendNotification("This is Push notification");

        }
    }
}
