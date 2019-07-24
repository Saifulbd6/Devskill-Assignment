using System;
using System.Collections.Generic;
using System.Text;

namespace DST0702
{
    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Human()
        {
            Console.WriteLine("Human CTOR is Called");
        }

        public virtual void Display()
        {
            Console.WriteLine("Human Name is "+Name);
            Console.WriteLine("Human Age is "+Age);
        }
    }
}
