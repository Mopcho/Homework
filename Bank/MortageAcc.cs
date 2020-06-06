using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class MortageAcc : BankAcc
    {
        public MortageAcc(double startingMoney) : base(startingMoney)
        {

        } 

        public override void CalulateInterest()
        {

        }
        public override void HandleMoney(string depoOrwithdraw, double money)
        {
            if (depoOrwithdraw == "Withdraw")
            {
                Console.WriteLine("Loan Acc can only Deposit");
            }
            else if (depoOrwithdraw == "Deposit")
            {
                this.Money += money;
            }
        }

    }
}
