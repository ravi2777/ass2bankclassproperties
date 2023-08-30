using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass2bankclassproperties
{
    public class BankAccount
    {
        // Properties
        public string AccountNumber { get; set;}
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }

        // Constructor
        public BankAccount(string accountNumber, string accountHolderName, double initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(double amount)
        {
            Balance += amount;
            Console.WriteLine($"{amount:C} deposited. New balance: {Balance:C}");
        }

        // Method to withdraw money
        public void Withdraw(double amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount:C} withdrawn. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}, Holder: {AccountHolderName}, Balance: {Balance:C}");
        }
    }

    public static class BankAccountUtility
    {
        public static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", "John Doe", 1000.0);

            account.DisplayAccountDetails();

            account.Deposit(500.0);
            account.Withdraw(200.0);
            account.Withdraw(1500.0);

            account.DisplayAccountDetails();
            Console.ReadLine();
        }
    }

}
