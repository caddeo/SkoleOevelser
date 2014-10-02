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

        public BankAccountClass(int accountNumber, string dateOpened, string accountType, double balance) {
            Random random = new Random();

            this.accountNumber = random.Next(10000, 99999) ;
            this.dateOpened = DateTime.Today.ToString("D");
            this.accountType = accountType;
            this.balance = 0.0;
        }

        public BankAccountClass(string accountType) : this(0, "", accountType, 0.0)
        {
            Console.WriteLine("Bank konto oprettet "+dateOpened +" med nummer " + accountNumber+" med balancen " + balance);   
        }
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
