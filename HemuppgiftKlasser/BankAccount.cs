using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HemuppgiftKlasser
{
    internal class BankAccount
    {
        //Properties
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; set; }

        //Constructor
        public BankAccount(string AccountNumber,string AccountHolder, decimal Balance)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHolder = AccountHolder;
            this.Balance = Balance;
        }

        //Methods
        public void Deposit(decimal Amount)
        {
            Balance += Amount;
            Console.WriteLine($"Deposited: {Amount}, New Balance: {Balance}");
        }

        public void Withdraw(decimal Amount)
        {
            if (Amount > Balance)
            {
                Console.WriteLine("Insufficient funds, withdrawal denied.");
            }
            else
            {
                Balance -= Amount;
                Console.WriteLine($"Withdrew: {Amount}, New Balance: {Balance}");
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }
}
