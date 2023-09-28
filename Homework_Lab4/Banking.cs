using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab4
{
    public delegate void BalanceChangedEvent(decimal newBalance);
    internal class Banking
    {
        private decimal balance;

        public event BalanceChangedEvent BalanceChanged;

        public Banking(decimal iniBalance)
        {
            balance = iniBalance;
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;

        }

        public void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                OnBalanceChanged(balance);
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        protected virtual void OnBalanceChanged(decimal newBalance)
        {
            BalanceChanged?.Invoke(newBalance);
        }
    }
}