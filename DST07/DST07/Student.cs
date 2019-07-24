using System;
using System.Collections.Generic;
using System.Text;

namespace DST07
{
    class Student
    {
        //public int Age = 10;
        //public readonly int Age = 10;
        //public const int Age =10;
        public  int Age => 10;
        public Student()
        {
            Age=20;
        }
        public Student(int age)
        {
            Age=age;
        }
        public void Display()
        {
            Age=30;
            Console.WriteLine("Age is "+Age);
        }
    }
}
