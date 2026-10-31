using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Behavioral
{
    //
    public interface IObserver
    {
        void Update(double price);
    }
    internal class ObserverPattern
    {

        public class MobileApp : IObserver
        {
            public void Update(double price) =>
                Console.WriteLine($"Mobile: Stock price = ₹{price}");
        }

        public class EmailService : IObserver
        {
            public void Update(double price) =>
                Console.WriteLine($"Email: Stock price = ₹{price}");
        }

        public class DirectService : IObserver
        {
            public void Update(double price) =>
                Console.WriteLine($"Direct: Stock price = ₹{price}");
        }

        public class Stock
        {       
            private readonly List<IObserver> _observers = new();

            public void Subscribe(IObserver observer) => _observers.Add(observer);
            public void SetPrice(double price)
            {
                Console.WriteLine($"Stock price changed to ₹{price}");

                foreach (var observer in _observers)
                    observer.Update(price);
            }
        }
    }
}
