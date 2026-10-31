using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Behavioral
{
    //Chain of Responsibility allows a request to be passed through a chain of handlers,
    //where each handler either processes the request or forwards it to the next handler.

    internal class ChainOfResponsibility
    {
        public abstract class Approver
        {
            protected Approver _next;

            public void SetNext(Approver next) => _next = next;

            public abstract void Approve(int amount);
        }

        public class Manager : Approver
        {
            public override void Approve(int amount)
            {
                if (amount <= 10000)
                    Console.WriteLine($"Manager approved ₹{amount}");
                else
                    _next?.Approve(amount);
            }
        }

        public class Director : Approver
        {
            public override void Approve(int amount)
            {
                if (amount <= 100000)
                    Console.WriteLine($"Director approved ₹{amount}");
                else
                    _next?.Approve(amount);
            }
        }

        public class CEO : Approver
        {
            public override void Approve(int amount)
            {
                Console.WriteLine($"CEO approved ₹{amount}");
            }
        }

    }
}
