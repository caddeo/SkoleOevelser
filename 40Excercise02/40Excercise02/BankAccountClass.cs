using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40Excercise02
{
    class BankAccountClass
    {
        public List<Postering> posteringer = new List<Postering>();

        public int accountNumber { get; set; }
        private double balance;
        public string dateOpened { get; set; }
        public string accountType { get; set; }

        public void Deposit(double amount)
        {
            balance = balance + amount;

            Postering postering = new Postering();
            postering.Beskrivelse = "Der blev indsat ";
            postering.Beløb = amount;

            posteringer.Add(postering);
        }

        public void Withdraw(double amount)
        {
            balance = balance - amount;

            Postering postering = new Postering();
            postering.Beskrivelse = "Der blev trukket ";
            postering.Beløb = amount;

            posteringer.Add(postering);
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
