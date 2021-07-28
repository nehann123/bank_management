using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Transaction
    {
        internal int TransactionID;
        internal int accountNumber;
        internal DateTime TransactionDate;
        internal double TransactionAmount;
        private static int count = 101;

        public Transaction()
        {
            TransactionID = 0;
            accountNumber = 0;
            TransactionAmount = 0;

        }
        public Transaction(int accountnumber, DateTime transactionDate, double transactionAmount)
        {
            TransactionID = count++;
            accountNumber = accountnumber;
            TransactionAmount = transactionAmount;
            TransactionDate = transactionDate;
        }

        public void Deposit()
        {
            Console.WriteLine("Enter acc number: ");
            int accountnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Deposit amount: ");
            double dep = Convert.ToDouble(Console.ReadLine());
            var acc = App.accountlist.Single(Account => Account.AccountNumber == accountnumber);
            acc.AccountBalance = acc.AccountBalance + dep;
            App.translist.Add(new Transaction(accountnumber, DateTime.Now, dep));

        }
        public void Withdraw()
        {
            Console.WriteLine("Enter acc number: ");
            int accountnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Withdraw amount: ");
            double withd = Convert.ToDouble(Console.ReadLine());
            var acc = App.accountlist.Single(Account => Account.AccountNumber == accountnumber);
            acc.AccountBalance = acc.AccountBalance - withd;
            App.translist.Add(new Transaction(accountnumber, DateTime.Now, withd));
        }
    }
}
