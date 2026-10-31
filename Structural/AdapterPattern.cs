using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Structural
{
    // Adapter acts as a bridge between two incompatible interfaces and performs the necessary conversion so that they can work together.
    internal class AdapterPattern
    {
        public interface IPayment
        {
            void Pay(double dollars);
        }

        class OldPaymentSystem
        {
            public void PayInCents(int cents)
            {
                Console.WriteLine($"Paid {cents} cents");
            }
        }

        public class PaymentAdapter : IPayment
        {
            private readonly OldPaymentSystem _oldPayment = new();

            public void Pay(double dollars)
            {
                int cents = (int)(dollars * 100);
                _oldPayment.PayInCents(cents);
            }
        }
                
    }
    
}

