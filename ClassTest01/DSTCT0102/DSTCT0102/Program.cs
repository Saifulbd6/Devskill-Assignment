using System;

namespace DSTCT0102
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please give a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            int reverse=0, mod = 0;
            while (input != 0)
            {
                mod=input%10;
                reverse=(reverse*10)+mod;
                input=input/10;
            }

            for (int i = 2; i<=Math.Sqrt(reverse); i++)
            {
                if (reverse%i==0)
                {
                    isPrime=false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("Result is: "+reverse+" (Prime)");
            }
            else
            {
                Console.WriteLine("Result is: "+reverse+" (Not Prime)");
            }
        }
    }
}
