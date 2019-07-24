using System;
using System.Collections.Generic;
using System.Text;

namespace DST05
{
    class Student
    {
        public string Name;
        public int Age;
        public double Cgpa;

        public void ResultCalculation()
        {

        }

        public void Display()
        {
            Console.WriteLine("Name is "+ Name);
            Console.WriteLine("Age is "+ Age);
            Console.WriteLine("Cgpa is "+ Cgpa);
        }
    }
}
