using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentsAndWorkers.Interfaces;

namespace StudentsAndWorkers.Classes
{
    public class Worker : Human, IWorker
    {
        private int _weekSalary;

        private int _workHoursPerday;

        public Worker(int weekSalary, int workHoursPerDay, string firstName, string lastName) : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this._workHoursPerday = workHoursPerDay;
        }

        public double MoneyPerHour(int workingDays)
        {
            double moneyPerHour = this._weekSalary / (workingDays * this._workHoursPerday);
            return moneyPerHour;
        }

        public int WeekSalary { get { return this._weekSalary; }
            private set
            {
                if(value < 10)
                {
                    throw new Exception("This is either a mistake made by you assigning the sallary or this is the poores worker out there");
                }
                this._weekSalary = value;
            }
        }

        public int WorkHoursPerDay { get { return this._workHoursPerday; }
            private set
            {
                if (value > 10)
                {
                    throw new Exception("This is either a mistake made by you assigning the work hours or this is the the most hardworking fella out there");
                }
                this._weekSalary = value;
            }
        }
    }
}
