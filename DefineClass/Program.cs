using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{  
    public enum BatteryType
    {
        LIon,
        NiMH,
        NiCd
}
   public class Battery
    {
        public BatteryType BatteryType { get; set; }
        public string Model { get; set; }
        public string HoursIdle { get; set; }
        public string Talk { get; set; }
        public Battery (string model,string hoursIdle,string talk,BatteryType batteryType)
        {
            this.BatteryType = batteryType;
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.Talk = talk;
        }
    }
    public class Display
    {
        public string Size { get; set; }
        public string Color { get; set; }
        public Display (string size,string color) 
            {
            this.Size=size;
            this.Color = color;
            }
    }

    public class GSM
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public decimal Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

        public GSM(string model = null,string manufacturer=null,decimal price=0,string owner=null,Battery battery=null,Display display=null)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Battery battery1 = new Battery("asdasasd","asdasdasd","asdasdas",BatteryType.LIon);
            Display display1 = new Display("10x10", "Niggerian");
            GSM number1 = new GSM("samsung","galaxy",300,"Shefa",battery1,display1);
            
          
        }
    }
}
