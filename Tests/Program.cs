using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public enum BatteryType
    {
        LIon,
        NiMH,
        NiCd
    }
    class Car
    {
        public string Model { get; }
        public string Acceleration { get; }
        public int MaxSpeed { get; }
        public string Color { get; }
        public double KilometerPerHour { get; }
        public Car(string model,string acceleration,int maxSpeed,string color,int kilometerPerHour)
        {
            this.Model = model;
            this.Acceleration = acceleration;
            this.MaxSpeed = maxSpeed;
            this.Color = color;
            this.KilometerPerHour = kilometerPerHour;
        }
        public void Drive(double roadLength)
        {
            double time = roadLength / this.KilometerPerHour;
            Console.WriteLine("You will reach your destination in {0:f2} hours",time);
        }



    }
   
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "100km/5 sec", 350, "Black", 70);
            car.Drive(100);
         

        }
    }
}
