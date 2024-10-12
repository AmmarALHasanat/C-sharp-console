using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Encapsulation
{
    internal class BankAccount
    {
        private decimal _balance = 0;
        public BankAccount(decimal balance)
        {
            _balance = balance;
        }
        // public decimal Balance { get { return _balance; } set { _balance = value; } }
        public decimal GetBalance() { return _balance; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be postive");
            }
            _balance += amount;
        }
        public void Withdraw(decimal amount) {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be postive");
            }
            if (amount > _balance) {
                throw new InvalidOperationException("Insufficient funds");
            }
            _balance -= amount;
        }


    }
}
