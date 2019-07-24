using System;
using System.Collections.Generic;
using System.Text;

namespace DST09
{
    class SYStudent : IHuman, IStudent
    {
        //public string Name { get; set; }
        //public string Age { get; set; }

        //public void Display()
        //{
        //    Console.WriteLine("SY Student is Called");
        //}
        //public void Display2()
        //{
        //    Console.WriteLine("SY Student is Called");
        //}
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Roll { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string GPA { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Display()
        {
            Console.WriteLine("SY Display");
        }
        void IStudent.Display()
        {
            Console.WriteLine("SY Student Display");
        }
        void IHuman.Display()
        {
            Console.WriteLine("SY Human Display");
        }
    }
}
