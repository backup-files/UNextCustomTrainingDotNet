using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Truck : IVehicle, ICrane
    {
        string color = "black";
        public string Color { get => color; set => color = value; }

        public void Brake()
        {
            Console.WriteLine("Break from Truck");
        }

        public void Drive()
        {
            Console.WriteLine("Drive from Truck");
        }

        void ICrane.Honk()
        {
            Console.WriteLine("ICrane.Honk from Truck");
        }

        void IVehicle.Honk()
        {
            Console.WriteLine("IVehicle.Honk from Truck");
        }
    }
}
