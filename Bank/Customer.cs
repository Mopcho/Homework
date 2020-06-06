using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Customer 
    {
        private string name;

        private T acc;

        private double money;
        
        public Customer(BankAcc bankAcc,string name,double customerMoney)
        {
            this.Money = customerMoney;
            this.Name = name;
            this.Acc = bankAcc;
        }
        public double Money
        {
            get
            {
                return this.money;
            }
            set
            {
                this.money = value;
            }
        }
        public BankAcc Acc {
            get
            {
                return this.acc;
            }
            private set
            {
                acc = value;
            }
        }

        public string Name {
            get
            {
                return this.name;
            }
            private set
            {
                name = value;
            }
        }
        public void minusMoney(double money)
        {
            this.Money -= money;
        }
    }
}
