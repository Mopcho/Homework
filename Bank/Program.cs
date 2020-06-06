using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Work in progress
namespace Bank
{
    class Program
    {
        static void Main()
        {
            LoanAcc loanAcc = new LoanAcc(2000);

            DepositAcc depoAcc = new DepositAcc(3000);

            Customer customer = new Customer(depoAcc,"Stoyan",4000);

            customer.Acc.HandleMoney("Deposit", 1000);

            Console.WriteLine(customer.Acc.Money);
            
        }
    }
}
