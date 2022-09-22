using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Parent
    {
        protected string skill = "HIGH";
        protected void ShowSkill()
        {
            Console.WriteLine($"Skill level is {this.skill}");
        }
        public void PrintNothing()
        {
            Console.WriteLine("Nothing");
        }
    }
}
