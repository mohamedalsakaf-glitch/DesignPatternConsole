using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternConsole.Structural
{
    // Proxy Pattern provides a surrogate or placeholder for another object to control access to it.
    internal class ProxyPattern
    {
        // write a proxy pattern for a bank account that has a method to withdraw money.
        // The proxy should check if the user is authenticated before allowing the withdrawal.    
        public interface IBankAccount
        {
            void Withdraw(double amount);
        }
        public class BankAccount : IBankAccount {
            public double amount;
                        
            public BankAccount(double initialAmount)
            {
                amount = initialAmount;
            }

            public void Withdraw(double amount)
            {
                if (this.amount >= amount)
                {
                    this.amount -= amount;
                    Console.WriteLine($"Withdrawn {amount}, remaining balance: {this.amount}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds");
                }
            }
        }

        public class BankAccountProxy : IBankAccount
        {
            private readonly BankAccount _bankAccount;
            private readonly bool _isAuthenticated;

            public BankAccountProxy(BankAccount bankAccount, bool isAuthenticated)
            {
                _bankAccount = bankAccount;
                _isAuthenticated = isAuthenticated;
            }

            public void Withdraw(double amount)
            {
                if (_isAuthenticated)
                {
                    _bankAccount.Withdraw(amount);
                }
                else
                {
                    Console.WriteLine("User is not authenticated");
                }
            }
        }
    }
}