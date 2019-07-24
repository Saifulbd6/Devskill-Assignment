using System;
using System.Collections.Generic;
using System.Text;

namespace DST0702
{
    class JobHolder : Human
    {
        public int Salary { get; set; } = 20000;

        public JobHolder()
        {
            Console.WriteLine("JobHolder CTOR is Called");
        }
        public override void Display()
        {
            //base.Display();
            Console.WriteLine("JobHolder Name is "+Name);
            Console.WriteLine("JobHolder Age is "+Age);
            Console.WriteLine("JobHolder Salary is "+Salary);
        }
    }

    class PvtJobHolder :JobHolder
    {
        public PvtJobHolder()
        {
            Console.WriteLine("Pvt JobHolder CTOR is Called");
        }
        public new void Display()
        {
            Console.WriteLine("PvtJobholder Name is "+Name);
            Console.WriteLine("PvtJobholder Age is "+Age);
            Console.WriteLine("PvtJobholder Salary is "+Salary);
        }
    }
}
