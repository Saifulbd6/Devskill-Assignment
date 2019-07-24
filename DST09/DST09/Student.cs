using System;
using System.Collections.Generic;
using System.Text;

namespace DST09
{
    class Student
    {
        //public int a { get; set; }
        //private int b { get; set; }
        //protected int c { get; set; }
        //internal int d { get; set; }
        public string Username { get; set; }
        public string Mobile { get; set; }

        public Course StudentCourse { get; set; }

        public void Display()
        {
            Console.WriteLine("Username "+Username);
            Console.WriteLine("Mobile "+Username);
            Console.WriteLine("Student Course Name "+StudentCourse.CourseName);
            Console.WriteLine("Student Course Fee "+StudentCourse.CourseFee);
        }

    }
}
