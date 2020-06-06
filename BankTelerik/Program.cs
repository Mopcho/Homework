using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankTelerik.AccountTypes;
using BankTelerik.Enum;
using BankTelerik.Interfaces;


namespace BankTelerik
{
    class Program
    {
        static void Main()
        {
            var bank = new Bank("International Asset Bank");

            bank.AddAccount(
                new DepositAccount(CustomerType.Individual, 2330, 45).WithDraw(250.23m), // Test WithDraw()
                new LoanAccount(CustomerType.Company, 250, 25).Deposit(250.23m), // Test Deposit()
                new LoanAccount(CustomerType.Individual, 444, 44), // Remove
                new MortgageAccount(CustomerType.Company, 2300, 15));

            bank.RemoveAccount(new LoanAccount(CustomerType.Individual, 444, 44));

            Console.WriteLine(bank);

            /* ------------ */

            Console.WriteLine(new DepositAccount(CustomerType.Individual, 2330, 45).CalculateInterestAmount(20));

            Console.WriteLine(new LoanAccount(CustomerType.Company, 250, 25).Deposit(250.23m).CalculateInterestAmount(15));

            Console.WriteLine(new MortgageAccount(CustomerType.Company, 2300, 15).CalculateInterestAmount(45) + "\n\n");

            /* ------------ */

            Console.WriteLine(new DepositAccount(CustomerType.Individual, 2330, 45)); 
        }
    }
}
