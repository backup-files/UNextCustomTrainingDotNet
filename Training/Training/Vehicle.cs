using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    abstract class Vehicle
    {
        public abstract void Brake();
    }

    class Bike : Vehicle
    {
        public override void Brake()
        {
            Console.WriteLine("Brake implemented in Bike");
        }
    }
}
