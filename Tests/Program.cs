using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
   
    class Car
    {
        private int Fuel { get; set; }
        public string Model { get; }
        public string Acceleration { get; }
        public int MaxSpeed { get; }
        public string Color { get; }
        public double KilometerPerHour { get; }
        private bool EngineOn { get; set; }
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
            if (EngineOn)
            {
                if (this.Fuel <= roadLength)
                {

                    Console.WriteLine("You need more fuel !");
                }
                else
                {

                    double time = roadLength / this.KilometerPerHour;
                    Console.WriteLine("You will reach your destination in {0:f2} hours", time);

                }
            }
            else
            {
                Console.WriteLine("Turn on the engine dumbass");
            }
        }
        public void ReFuel(int filling)
        {
            this.Fuel = this.Fuel + filling;
        }
        public void DisplayFuel()
        {
            Console.WriteLine(this.Fuel);
        }
        public void StartEngine()
        {
            Console.WriteLine("Brrrrrrrr");
            this.EngineOn = true;
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
