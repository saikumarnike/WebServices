using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WCFHttpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorService.CalculatorServiceClient client = new CalculatorService.CalculatorServiceClient("BasicHttpBinding_ICalculatorService");
            Console.WriteLine(client.Add(6, 7));
        }
    }
}
