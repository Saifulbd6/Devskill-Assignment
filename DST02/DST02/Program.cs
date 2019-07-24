using System;

namespace DST02
{
    class Program
    {
        static void Main()
        {
            //int a = 10;
            //bool b = false;
            //float f = 10.5f;
            //double d = 5.021;
            //decimal de = 5.555m;

            //a=Convert.ToInt16(d);

            //Console.WriteLine("Hello World "+ d.ToString().GetType());
            //Console.WriteLine("Hello World {0}", a);


            //object x = 10.06;
            //dynamic y = 20.5;

            //Console.WriteLine(x.GetType());
            //Console.WriteLine(y);

            //int zz=10,yy=20;

            //var z = 10 ;
            //Console.WriteLine(z.GetType());

            //Guid g = Guid.NewGuid() ;
            //Console.WriteLine(g);

            //DateTime d = DateTime.Now;
            //Console.WriteLine(d);

            //double age = Convert.ToDouble(Console.ReadLine()); ;
            //Console.WriteLine(age);

            //ConsoleKeyInfo d = Console.ReadKey();
            //Console.WriteLine(d.Key);

            int ?a = null;
            string name = null;
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("No Name");
            }
            else
            {
                Console.WriteLine("Test "+name);
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("No Name");
            }
            else
            {
                Console.WriteLine("Test "+name);
            }

        }
    }
}
