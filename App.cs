using System;
using System.Collections.Generic;

namespace BankManagement
{
    class App
    {

        public static List<Account> accountlist = new List<Account>();
        public static List<Transaction> translist = new List<Transaction>();
        static void Main(string[] args)
        {

            Console.WriteLine("WELCOME TO THE BANK\n-----------------------------------");
            while (true)
            {
                Console.WriteLine("============\n============\nWhat do you wanna do:\n1.Create an Account\n2.Close an Account\n3.Diposite money" +
                    "\n4.Withdraw money\n5.Show Bank Details\n6.Show all the accounts:");
                int choice = Convert.ToInt32(Console.ReadLine());
                Account ac = new Account();
                Transaction tr = new Transaction();
                switch (choice)
                {
                    case 1:
                        ac.CreateAC();
                        break;
                    case 2:
                        ac.CloseAC();
                        break;
                    case 3:
                        tr.Deposit();
                        break;
                    case 4:
                        tr.Withdraw();
                        break;
                    case 5:
                        ac.showAccountDetails();
                        break;
                    case 6:
                        ac.showAllAcc();
                        break;
                }

            }

        }
    }
}
