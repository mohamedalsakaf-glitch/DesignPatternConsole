using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Behavioral
{
    //
    interface IPaymentStrategy
    {
        void Pay(double amount);
    }
    
    class CreditCardPayment : IPaymentStrategy
    {
        public void Pay(double amount) =>
            Console.WriteLine($"Paid ₹{amount} using Credit Card");
    }

    class UpiPayment : IPaymentStrategy
    {
        public void Pay(double amount) =>
            Console.WriteLine($"Paid ₹{amount} using UPI");
    }

    class PaymentContext
    {
        private IPaymentStrategy _strategy;

        public PaymentContext(IPaymentStrategy strategy)
            => _strategy = strategy;

        public void MakePayment(double amount)
            => _strategy.Pay(amount);
    }

}
