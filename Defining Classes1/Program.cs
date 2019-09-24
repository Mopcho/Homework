using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
    class Program
    {
        static void Main(string[] args)
        {

            Battery battery = new Battery(20,21,BatteryType.LiIon);
            GSMCallHistoryTest.Test("Samsung","SamsungVe",200,"Misho",battery);

            
        }
    }
}
