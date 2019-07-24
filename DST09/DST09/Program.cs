using System;

namespace DST09
{
    class Program
    {
        static void Main(string[] args)
        {
            //IStudent h = new SYStudent();
            //h.Display();
            ////h.Display2();

            Course c1 = new Course();
            c1.CourseName="C# Course";
            c1.CourseFee=4000;
            Course c2 = new Course();
            c2.CourseName="C# Course Advance";
            c2.CourseFee=30000;


            Student s = new Student();
            s.Username="abc";
            s.Mobile="0565661561554";
            //s.CourseName="C# Course";
            //s.CourseFee=4000;
            s.StudentCourse=c1;
            s.Display();

            Student s2 = new Student();
            s2.Username="abcdd";
            s2.Mobile="0565661561554";
            //s.CourseName="C# Course";
            //s.CourseFee=4000;
            s2.StudentCourse=c1;


        }
    }
}
