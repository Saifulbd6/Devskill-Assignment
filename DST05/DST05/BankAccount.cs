using System;
using System.Collections.Generic;
using System.Text;

namespace DST05
{
    class BankAccount
    {
        public string AccountName;
        public string AccountNumber;
        //private double _Balance;
        //public double AccountBalance
        //{
        //    get
        //    {
        //        
        //        return _Balance;
        //    }
        //    set
        //    {
        //        
        //        _Balance=value;
        //    }
        //}
        //public double AccountBalance;
        public double AccountBalance { get; set; }

        //public double GetAccountBalance()
        //{
        //    return AccountBalance;
        //}
        //public void SetAccountBalance(double amount)
        //{
        //    //SMS
        //    AccountBalance=amount;
        //}

        public void Display()
        {
            Console.WriteLine("Amount "+AccountBalance);
        }
    }
}
