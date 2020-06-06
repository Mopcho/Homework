using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BankTelerik.Enum;
using BankTelerik.Interfaces;
using System.Threading.Tasks;

namespace BankTelerik.AccountTypes
{
    class MortgageAccount : Account, IDeposit<MortgageAccount>
    {
        public MortgageAccount(CustomerType customerType, decimal balance, decimal interestRate)
            : base(customerType, balance, interestRate)
        {
        }

        public MortgageAccount Deposit(decimal money)
        {
            this.Balance += money;

            return this;
        }

        public override decimal CalculateInterestAmount(decimal numberOfMonths)
        {
            if (this.CustomerType == CustomerType.Company)
                return base.CalculateInterestAmount(Math.Min(numberOfMonths, 12) / 2 + Math.Max(numberOfMonths - 12, 0));

            if (this.CustomerType == CustomerType.Individual)
                return base.CalculateInterestAmount(numberOfMonths - 6);

            return base.CalculateInterestAmount(numberOfMonths);
        }
    }
}
