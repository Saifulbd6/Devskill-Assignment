using System;
using System.Collections.Generic;
using System.Text;

namespace DST08
{
    class Student : Human
    {
        public int Roll { get; set; }
        public Student()
        {
            Console.WriteLine("Student CTOR");
        }
        public Student(int roll)
        {
            Console.WriteLine("Student CTOR 2");
            Roll=roll;
        }
        public Student(int roll,string name1,int age) : base(name1,age)
        {
            Console.WriteLine("Student CTOR 2");
            Roll=roll;
        }
        public void Display()
        {

        }
        public void Display(int age)
        {

        }
        public void Display(int age, int age2)
        {
            
        }
        public void Display(int age, string name)
        {

        }

    }
}
