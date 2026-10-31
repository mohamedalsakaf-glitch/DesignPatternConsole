using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Creational
{
    //Factory Method Pattern is used when object creation logic
    //needs to be separated from the client code, allowing the factory to decide which concrete object should be created.
    internal class FactoryMethod
    {
    
        public interface INotification
        {
            void Send(string message);
        }

        class EmailNotification : INotification
        {
            public void Send(string message) => Console.WriteLine($"Email: {message}");
        }

        class SmsNotification : INotification
        {
            public void Send(string message) => Console.WriteLine($"SMS: {message}");
        }

        public class NotificationFactory
        {
            public static INotification Create(string type)
            {
                return type.ToLower() == "email"
                    ? new EmailNotification()
                    : new SmsNotification();
            }
        }

    }
}
