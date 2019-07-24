using System;

namespace DSTCT0101
{
    class Program
    {
        static void Main(string[] args)
        {
            int year, month, day;
            Console.Write("Please enter year: ");
            while (true)
            {
                year=Convert.ToInt32(Console.ReadLine());
                if (year >=1971 && year <=2019)
                {
                    break;
                }
                Console.WriteLine("Sorry, you provide an invalid year. Try again!");
                Console.Write("Please enter year: ");
            }

            Console.Write("Please enter month: ");
            while (true)
            {
                month=Convert.ToInt32(Console.ReadLine());
                if (month>=1&&month<=12)
                {
                    break;
                }
                Console.WriteLine("Sorry, you provide an invalid month. Try again!");
                Console.Write("Please enter month: ");
            }

            Console.Write("Please enter day: ");
            while (true)
            {
                day=Convert.ToInt32(Console.ReadLine());
                if (month==2 && (day >=1 && day <=28))
                {
                    break;
                }else if ((month==4||month==6||month==9||month==11)&&(day>=1&&day<=30) )
                {
                    break;
                }
                else if ((month==1||month==2||month==5||month==7||month==8||month==10||month==12)&&(day>=1&&day<=31))
                {
                    break;
                }
                Console.WriteLine("Sorry, you provide an invalid day. Try again!");
                Console.Write("Please enter day: ");
            }
            Console.WriteLine("Your Date is: "+new DateTime(year, month, day).ToShortDateString());

        }
    }
}
