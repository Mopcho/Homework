using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers.Interfaces
{
    public interface IWorker
    {
        int WeekSalary { get; }

        int WorkHoursPerDay { get; }
    }
}
