using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automobile
{
    public abstract class Car
    {
        private CarModels carModel;

        private int maxSpeed;

        public Car(int maxSpeed,CarModels carModel)
        {
            this.carModel = carModel;
            this.maxSpeed = maxSpeed;
        }

        

    }
}
