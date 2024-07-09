using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Q.3  • You have a class which has methods for transaction for a banking system. (created earlier)
//      • Define your own methods for deposit money, withdraw money and balance in the account.
//      • Write your own new application Exception class called InsuffientBalanceException.
//      • This new Exception will be thrown in case of withdrawal of money from the account where customer doesn’t have sufficient balance.
//      • Identify and categorize all possible checked and unchecked exception.


namespace Assignment_4
{

    // Custom Exception class for insufficient balance
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException() { }
        public InsufficientBalanceException(string message) : base(message) { }
        public InsufficientBalanceException(string message, Exception innerException) : base(message, innerException) { }
    }

    // BankAccount class representing a bank account
    public class BankAccount                    //A bank account with methods for depositing, withdrawing, and checking balance. 
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            if (initialBalance < 0)
            {
                throw new ArgumentException("Initial balance cannot be negative.");         //Works only if initial balance is less that zero.
            }
            this.balance = initialBalance;
        }

        // Method to deposit money into the account
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
            Console.WriteLine($"Deposited: ${amount}, Current Balance: ${balance}");
        }

        // Method to withdraw money from the account
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (balance < amount)
            {
                throw new InsufficientBalanceException("Insufficient balance for withdrawal.");
            }
            balance -= amount;
            Console.WriteLine($"Withdrawn: ${amount}, Current Balance: ${balance}");
        }

        // Method to check the current balance
        public double GetBalance()
        {
            return balance;                 //Current Balance.
        }
    }

    class BankingSystem
    {
        static void Main()
        {
            try
            {
                // Creating a bank account with initial balance of $1000
                BankAccount account = new BankAccount(1000);

                // Performing transactions
                account.Deposit(500);
                account.Withdraw(200);
                account.Withdraw(1500);                  // This should throw InsufficientBalanceException

                // Displaying final balance
                Console.WriteLine($"Final Balance: ${account.GetBalance()}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Argument Exception: {ex.Message}");
            }
            catch (InsufficientBalanceException ex)
            {
                Console.WriteLine($"Insufficient Balance Exception: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }


            /* ~ ~ ~ ~ These are only for Decoration Perpose ~ ~ ~ ~ */
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ Programs Execute Sucessfully ~ ~    ");
            Console.WriteLine("");
            Console.WriteLine(" ~ ~ ~ ~ END OF PROGRAM ~ ~ ~            ");
            Console.WriteLine(" Please Click Any Key To Exit.           ");
            Console.ReadKey();


        }
    }
}
