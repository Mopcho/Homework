using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_Classes1
{
    public class Phone
    {
        public string Model { get { return _model; } set { _model = value; } }
        public string Manufacturer { get { return _manufacturer; } set { _manufacturer = value; } }
        public double Price { get { return _price; } set { _price = value; } }
        public string Owner { get { return _owner; } set { _owner = value; } }
        public Battery Battery { get { return _battery; } set { _battery = value; } }
        public Display Display { get { return _display; } set { _display = value; } }
        public List<Call> CallHistory { get; set; }
        public static Phone IPhone4S { get { return _iPhone4S; } }
        private string _model;
        private string _manufacturer;
        private double _price;
        private string _owner;
        private Battery _battery;
        private Display _display;
        public static Phone _iPhone4S = new Phone("iPhone", "Apple");
        public Phone(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallHistory = new List<Call>();

        }
        public Phone(string model, string manufacturer, double price, string owner, Battery battery)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.CallHistory = new List<Call>();
        }
        public void CalculatePrice()
        {
            double sum=0;
           
             for (int i=0;i<CallHistory.Count;i++)
             {
               sum =sum+ ((CallHistory[i].Duration)/60)*2;
             }
           
            Console.WriteLine(sum);
        }
        public void AddCall(DateTime date,TimeSpan time,int dialedNumber,int duration)
        {
            var call = new Call(date,time,dialedNumber,duration);
            this.CallHistory.Add(call);
        }
        public void DeleteCall(int index)
        {
            this.CallHistory.RemoveAt(index);
        }
        public void ClearHistory()
        {
            this.CallHistory.Clear();
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
}
