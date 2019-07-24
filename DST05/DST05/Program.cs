using System;

namespace DST05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student s1 = new Student();
            //s1.Name="Jamal";
            //s1.Age=21;
            //s1.Cgpa=3.5;
            //s1.Display();

            //Student s2 = new Student();
            //s2.Name="Kamal";
            //s2.Age=20;
            //s2.Cgpa=3.15;
            //s2.Display();

            BankAccount b = new BankAccount();
            b.AccountName="Shovon";
            b.AccountNumber="123-456-789";
            //b.SetAccountBalance(500);
            b.AccountBalance=500;
            b.Display();
            Console.WriteLine(b.AccountName);
        }
    }
}
