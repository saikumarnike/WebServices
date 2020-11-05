﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using(ServiceHost host=new ServiceHost(typeof(CalculatorWCFService.CalculatorService)))
            {
                host.Open();
                Console.WriteLine("Host Started @"+DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
