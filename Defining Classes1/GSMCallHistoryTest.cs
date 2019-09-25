using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Defining_Classes1
{
    public static class GSMCallHistoryTest
    {
        public  static void Test(string model,string manufacturer,int price,string owner,Battery battery)
        {
            Phone GSM = new Phone(model, manufacturer, price, owner, battery);
            GSM.AddCall(DateTime.Now, TimeSpan.FromHours(2.00), 089321213, 1000);
            GSM.AddCall(DateTime.Now, TimeSpan.FromHours(3.00), 0893222213, 2000);
            GSM.CalculatePrice();

            List<Call> SortedList = GSM.CallHistory.OrderBy(o => o.Duration).ToList();
      
            SortedList.RemoveAt(0);
            GSM.ClearHistory();
            GSM.CallHistory = SortedList;
            GSM.CalculatePrice();

            
        }
       
    }
}
