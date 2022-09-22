using System;
using System.Collections.Generic;
using System.Text;

namespace Basics
{
    class Student
    {
        Stack<string> names = new Stack<string>();
        public void AddStudent(string name)
        {
            this.names.Push(name);
        }
        public string RemoveStudent()
        {
            return this.names.Pop();
        }
        public string GetStudent()
        {
            return this.names.Peek();
        }
        public string[] GetStudents()
        {
            return names.ToArray();
        }
    }
}
