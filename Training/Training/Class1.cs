using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class ExtensionClass
    {
        public string s = "hi";
        public void M1()
        {
            Console.WriteLine("ExtensionClass.M1()");
        }
    }

    static class ExtensionMethods
    {
        public static void M2(this ExtensionClass e)
        {
            Console.WriteLine($"ExtensionMethods.M2() - {e.s}");
        }
    }
}
