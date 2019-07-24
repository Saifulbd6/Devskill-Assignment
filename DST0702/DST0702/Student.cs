using System;
using System.Collections.Generic;
using System.Text;

namespace DST0702
{
    class Student : Human
    {
        public double GPA { get; set; }
        public Student()
        {
            Console.WriteLine("Student CTOR is called");
        }
        public override void Display()
        {
            Console.WriteLine("Name is "+Name);
            Console.WriteLine("Age is "+Age);
            Console.WriteLine("GPA is "+GPA);
        }
    }
}
