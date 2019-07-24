using System;
using System.Collections.Generic;
using System.Text;

namespace DST06
{
    class Student
    {
        public string Name { get; set; }
        public int? Age { get; set; }

        public Student()
        {
            Age=18;
        }
        public Student(int age) => this.Age=age;

        public Student(int Age, string Name)
        {
            this.Age=Age;
            this.Name=Name;
        }
        ~Student()
        {
            //
            Console.WriteLine("Destructor is Called");
        }
        //~Student() => Console.WriteLine("Destructor is Called");
        public void Display()
        {
            Console.WriteLine("Name "+Name);
            Console.WriteLine("Age "+Age);
        }
    }
}
