using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    interface IVehicle
    {
        string Color { get; set; }
        void Drive();
        void Honk();
        void Brake();
    }
}
