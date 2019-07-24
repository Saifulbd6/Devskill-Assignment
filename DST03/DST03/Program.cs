using System;

namespace DST03
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 10;
            switch (s)
            {
                case 1:
                    Console.WriteLine("This is 1");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("This is 9");
                    break;
                default:
                    Console.WriteLine("This is 10");
                    break;
            }

            int a = 10;
            int b = 20;

            int max = a>b ? a : b;

            int? age = null;

            int newAge = age??20;

            string name = "ok";


            Console.WriteLine(name.ToUpper());
        }
    }
}
