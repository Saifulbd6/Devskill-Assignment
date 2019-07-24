using System;
using System.Collections.Generic;
using System.Text;

namespace DST09
{
    interface IHuman
    {
        string Name { get; set; }
        string Age { get; set; }
        void Display();
    }

    interface IStudent
    {
        string Roll { get; set; }
        string GPA { get; set; }
        void Display();
    }
}
