using System;
using System.Collections.Generic;
using System.Text;

namespace DSTCP01
{
    class Circle
    {
        public double Radius { get; set; }
        public string Color { get; private set; } = "Red";

        public Circle()
        {
            Radius=1.5;
        }
        public Circle(int radius)
        {
            Radius=radius;
        }
        private double CalculateArea()
        {
            return 3.14*Radius*Radius;
        }
        public void CircleDetails()
        {
            Console.WriteLine("Area is "+CalculateArea());
            Console.WriteLine("Color is "+Color);
            Console.WriteLine("Radius is "+Radius);
        }
    }
}
