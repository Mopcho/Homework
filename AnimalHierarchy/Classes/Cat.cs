﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimalHierarchy.Interfaces;

namespace AnimalHierarchy.Classes
{
    public class Cat : Animal , ISound
    {
        public Cat(int age, string name, string sex) : base(age, name, sex)
        {

        }
        public void Sound()
        {
            Console.WriteLine("Meow");
        }
    }
}
