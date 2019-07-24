using System;

namespace DST06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student(28, "Jaman");
            //s1.Display();
            //Student s2 = new Student();
            //s2.Name="Rahim";
            //s2.Display();

            Details("Jamal", 20);
            Details("Kamal", 25);
            Details("Rahim", 30);
            GC.Collect();


        }
        static void Details(string name,int age)
        {
            Student std = new Student(age,name);
            std.Display();
        }
    }
}
