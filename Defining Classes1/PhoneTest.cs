using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
    public static class PhoneTest
    {
        public static void Test()
        {
            Phone[] phoneArr = {new Phone("Samusung","Toshiba",300,"Georgi",new Battery(10,10,BatteryType.LiIon)),new Phone("Osaka","Mitsubishi") };
            for (int i=0;i<phoneArr.Length;i++)
            {
                Console.WriteLine(phoneArr[i]);
            }
            Console.WriteLine(Phone.IPhone4S);
        }

    }
}
