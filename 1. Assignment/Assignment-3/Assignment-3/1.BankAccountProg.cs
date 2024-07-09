using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Accounts
    {
        //Data Members
        private int accountNo;
        private string customerName;
        private string accountType;
        private char transactionType;
        private double amount;
        private double balance;

        // Constructor-To Initialize Account Details
        public Accounts(int accountNo, string customerName, string accountType, char transactionType, double amount)
        {
            this.accountNo = accountNo;
            this.customerName = customerName;
            this.accountType = accountType;
            this.transactionType = transactionType;
            this.amount = amount;
            this.balance = 10000;                   // Start with 10,000 balance
        }

        //Function- Update Balance depending upon the Transaction Type
        public void UpdateBalance()
        {
            if (transactionType == 'D')
            {
                Credit(amount);
            }
            else if (transactionType == 'W')
            {
                Debit(amount);
            }
            else
            {
                Console.WriteLine("Invalid transaction type.");
            }
        }

        //Function- Credit Operation
        private void Credit(double amount)
        {
            balance += amount;
            Console.WriteLine($"Amount {amount} credited successfully.");
        }

        //Function- Debit Operation
        private void Debit(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Amount {amount} debited successfully.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        //Function- Display Account Details
        public void ShowData()
        {
            Console.WriteLine($"Account Number: {accountNo}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Account Type: {accountType}");
            Console.WriteLine($"Transaction Type: {transactionType}");
            Console.WriteLine($"Current Balance: {balance}");
        }
    }

    class BankAccountProg
    {
        static void Main()
        {
            Accounts account1 = new Accounts(12345678, "Abhishek Kumar", "Savings", 'D', 3500);
            account1.UpdateBalance();
            account1.ShowData();

            Console.WriteLine();

            Accounts account2 = new Accounts(98765432, "Aisha Aditi", "Savings", 'W', 2500);
            account2.UpdateBalance();
            account2.ShowData();

            Console.ReadLine();
        }
    }
}
