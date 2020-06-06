using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public abstract class BankAcc 
    {
        private double money;

        public double Money {
            get
            {
                return this.money;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Money cant be less than 0");
                }
                this.money = value;
            }
        }

        public BankAcc(double startingMoney)
        {
            this.Money = startingMoney;
        }

        public abstract void HandleMoney(string depoOrwithdraw, double money);
       
        public abstract void CalulateInterest();
    }
}
