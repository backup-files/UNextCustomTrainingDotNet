using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Jeep : IVehicle
    {
        string color = "red";
        public string Color { get => color; set => color = value; }

        public void Brake()
        {
            Console.WriteLine("Brake from Jeep");
        }

        public void Drive()
        {
            Console.WriteLine("Drive from Jeep");
        }

        public void Honk()
        {
            Console.WriteLine("Honk from Jeep");
        }
    }
}
