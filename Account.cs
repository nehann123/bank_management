using System;
using System.Linq;

namespace BankManagement
{
    enum AccountType
    { savings, current };
    class Account
    {
        internal string AccountHolderName = null;
        internal int AccountNumber;
        internal AccountType accountType;
        internal DateTime AccountCreationDate;
        internal double AccountBalance;
        private static int count = 10001;

        public Account()
        {
            accountType = AccountType.savings;
            accountType = (AccountType)0;
        }

        public Account(string accountHolderName, int type)
        {

            AccountHolderName = accountHolderName;
            AccountNumber = count++;
            accountType = (AccountType)type;
            AccountCreationDate = DateTime.Now;
            AccountBalance = 0;

        }

        public void CreateAC()
        {
            Console.WriteLine("Enter acc holder name: ");
            string accountHolderName = Console.ReadLine();
            Console.WriteLine("Enter acc type\n0.Saving\n1.current: ");
            int atype = Convert.ToInt16(Console.ReadLine());
            Account acc = new Account(accountHolderName, atype);
            App.accountlist.Add(acc);

            Console.WriteLine("\nNAME: " + acc.AccountHolderName + "\nACCOUNT NUMBER: " + acc.AccountNumber + "\nACCOUNT BALANCE: "
                + acc.AccountBalance + "\nACCOUNT TYPE: " + acc.accountType + "\nDATE OF CREATION:" + acc.AccountCreationDate);


        }
        public void CloseAC()
        {
            Console.WriteLine("Enter acc number: ");
            int accountNumber = Convert.ToInt32(Console.ReadLine());
            var itemToRemove = App.accountlist.Single(Account => Account.AccountNumber == accountNumber);
            App.accountlist.Remove(itemToRemove);

        }

        public void showAccountDetails()
        {
            Console.WriteLine("Enter acc number: ");
            int accountnumber = Convert.ToInt32(Console.ReadLine());
            var acc = App.accountlist.Single(Account => Account.AccountNumber == accountnumber);
            //var acc = (from Account in App.accountlist where Account.AccountNumber == accountnumber select Account);
            var tacc = App.translist.LastOrDefault(Account => Account.accountNumber == accountnumber);

            Console.WriteLine("\nNAME: " + acc.AccountHolderName + "\nACCOUNT NUMBER: " + acc.AccountNumber + "\nACCOUNT BALANCE: "
                + acc.AccountBalance + "\nACCOUNT TYPE: " + acc.accountType + "\nDATE OF CREATION:" + acc.AccountCreationDate
                + "\nTRANSACTION ID: " + tacc.TransactionID + "\nTRANSACTION AMOUNT: " + tacc.TransactionAmount
                + "\nTRANSACTION DATE: " + tacc.TransactionDate);


        }
        public void showAllAcc()
        {
            foreach (Account acc in App.accountlist)
            {
                Console.WriteLine("\nNAME: " + acc.AccountHolderName + "\nACCOUNT NUMBER: " + acc.AccountNumber + "\nACCOUNT BALANCE: "
               + acc.AccountBalance + "\nACCOUNT TYPE: " + acc.accountType + "\nDATE OF CREATION:" + acc.AccountCreationDate);
            }
        }
    }
}
