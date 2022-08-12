using System;
using System.Collections.Generic;
using Vsevolod.LLCpayrollSoftware.Domain;
using Vsevolod.LLCpayrollSoftware.Persistence;

namespace LLCpayrollSoftwareDevelop
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager("test", new List<TimeRecord>()
            {
                new TimeRecord(DateTime.Now.AddDays(-3),"test",8,"test message"),
                new TimeRecord(DateTime.Now.AddDays(-2),"test",9,"test message"),
                new TimeRecord(DateTime.Now.AddDays(-1),"test",7,"test message"),
            });

            Console.WriteLine(manager.TotalPay); 
            Console.ReadLine();
        }
    }
}
