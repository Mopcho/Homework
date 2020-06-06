using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class DepositAcc : BankAcc
    {
       public DepositAcc(double startingMoney) :base(startingMoney)
       {

       }
       public override void CalulateInterest()
        {
            
        }

        public override void HandleMoney(string depoOrwithdraw, double money)
        {
            if (depoOrwithdraw == "Withdraw")
            {
                this.Money -= money;
            }
            else if (depoOrwithdraw == "Deposit")
            {
                this.Money += money;
            }
        }
    }
}
