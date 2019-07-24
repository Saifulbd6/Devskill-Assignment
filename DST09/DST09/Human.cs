using System;
using System.Collections.Generic;
using System.Text;

namespace DST09
{
    public abstract class Human
    {
        public  string Name { get; set; }
        public abstract string Age { get; set; }
        public abstract void Display();
    }
}
