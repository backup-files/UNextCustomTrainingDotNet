using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Child: Parent
    {
        public new void ShowSkill()
        {
            Console.WriteLine("ShowSkill from child class");
            base.ShowSkill();
        }
        public void PrintInheritedProperties()
        {
            Console.WriteLine($"skill property holds the value: {skill}");
            ShowSkill();
        }
    }
}
