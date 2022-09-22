using System;

namespace Basics
{
    class Car
    {
        string color = "red";
        int year = 2000;
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public int Year { get => year; set => year = value; }

        public Car() { }
        public Car(string color)
        {
            this.color = color;
        }
        public Car(string color, int year)
        {
            this.color = color;
            this.year = year;
        }
        public void CheckAge()
        {
            if (this.Year > 2010)
            {
                Console.WriteLine("This car is new!");
            }
            else
            {
                Console.WriteLine("This car is old!");
            }
        }

        public void PrintFuelType(string fuelType)
        {
            Console.WriteLine($"This car uses {fuelType}");
        }
    }
}
