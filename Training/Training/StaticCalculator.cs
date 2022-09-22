using System;
using static Print.Print;

namespace Basics
{
    class StaticCalculator
    {
        public static void Run()
        {
            var x = 10;
            var y = 5;
            print(
                x, y, x + y, x - y, x * y, x / y
            );
            Console.WriteLine($"{x}, {y}, {x + y}, {x - y}, {x * y}, {x / y}");

        }
    }
}
