using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Behavioral
{
    // 
    internal class StatePattern
    {
        public interface IOrderState
        {
            void Process(Order order);
        }

        class CreatedState : IOrderState
        {
            public void Process(Order order)
            {
                Console.WriteLine("Order created. Processing payment...");
                order.SetState(new PaidState());
            }
        }

        class CancelledState : IOrderState
        {
            public void Process(Order order)
            {
                Console.WriteLine("Order cancelled...");
                //order.SetState(new PaidState());
            }
        }

        class PaidState : IOrderState
        {
            public void Process(Order order)
            {
                Console.WriteLine("Payment completed. Shipping order...");
                order.SetState(new ShippedState());
            }
        }

        class ShippedState : IOrderState
        {
            public void Process(Order order)
            {
                Console.WriteLine("Order shipped. Delivering...");
                order.SetState(new DeliveredState());
            }
        }

        class DeliveredState : IOrderState
        {
            public void Process(Order order)
                => Console.WriteLine("Order already delivered.");
        }

        public class Order
        {
            private IOrderState _state = new CreatedState();

            public void SetState(IOrderState state) => _state = state;

            public void Process() => _state.Process(this);
        }
    }
}

