using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
    public enum BatteryType
    {
        LiIon, NiMH, NiCd
    }
    public class Battery
    {
        public int HoursIdle { get; set; }
        public int HoursTalk { get; set; }
        public BatteryType Model { get; set; }
        public Battery(int hoursIdle, int hoursTalk, BatteryType model)
        {
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Model = model;
        }
    }
    public class Display
    {
        public int Size { get; set; }
        public int NumberOfColors { get; set; }
        public Display(int size, int numberOfColors)
        {
            this.Size = size;
            this.NumberOfColors = numberOfColors;
        }
    }
    public class Phone
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public string Owner { get; set; }
        public Battery Battery { get; set; }
        public Display Display { get; set; }

        public Phone(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;

        }
        public Phone(string model, string manufacturer, double price, string owner, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
        }
        public string DisplayInfo()
        {
            return string.Format("Model : {0} r\n Manufacturer : {1} r\n Price : {2} r\n Owner : {3} r\n HoursIdle : {4} r\n Hours Talk {5} r\n BatteryModel : {6} r\n Size : {7} r\n Number Of Colors : {8}"
                , this.Model, this.Manufacturer, this.Price, this.Owner, this.Battery.HoursIdle, this.Battery.HoursTalk, this.Battery.Model, this.Display.Size, this.Display.NumberOfColors);

        }
        public override string ToString()
        {
            return this.DisplayInfo();
        }


    }
   
    class Program
    {
        static void Main(string[] args)
        {
           
        }
    }
}
