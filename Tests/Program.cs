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
        private string Acceleration { get; }
        private int MaxSpeed { get; set; }
        private string Color { get; set; }
        public double KilometerPerHour { get; }
        private bool EngineOn { get; set; }
        public int DirtyLevel { get; set; } = 10;
        public Car(string model,string acceleration,int maxSpeed,string color,int kilometerPerHour,int dirtyLevel)
        {
            this.Model = model;
            this.Acceleration = acceleration;
            this.MaxSpeed = maxSpeed;
            this.Color = color;
            this.KilometerPerHour = kilometerPerHour;
            this.DirtyLevel = dirtyLevel;
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
        public void StopEngine()
        {
            Console.WriteLine("Buuuuu");
            this.EngineOn = false;
        }
        public void Honk()
        {
            Console.WriteLine("Beeeep");
        }
        public void DisplayStats()
        {
            Console.WriteLine("Model : {0} - Acceseleration : {1} - Max Speed : {2} - Color : {3} - Kilimeter Per Hour : {4}",Model,Acceleration,MaxSpeed,Color,KilometerPerHour);
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
