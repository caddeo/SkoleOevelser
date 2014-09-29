using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise02
{
    class BankAccountClass
    {
        public int accountNumber { get; set; }
        private double balance;
        public string dateOpened { get; set; }
        public string accountType { get; set; }

        public void Deposit(double amount)
        {
            balance = balance + amount;
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
