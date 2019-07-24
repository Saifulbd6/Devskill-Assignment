using System;

namespace DSTCP01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Provide Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle c1 = new Circle();
            c1.Radius=r;
            c1.CircleDetails();
        }
    }
}
