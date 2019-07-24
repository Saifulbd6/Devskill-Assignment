using System;
using System.Collections.Generic;
using System.Text;

namespace DST08
{
    class Human
    {
        private string Name { get; set; }
        private int Age { get; set; }
        public Human()
        {
            Console.WriteLine("Human CTOR");
        }
        public Human(string name,int age)
        {
            Console.WriteLine("Human CTOR 2");
            Name=name;
            Age=age;
        }
    }
}
