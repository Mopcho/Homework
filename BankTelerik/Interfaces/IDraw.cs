using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankTelerik.Interfaces
{
    interface IDraw<T>
    {
        T WithDraw(decimal money);
    }
}
