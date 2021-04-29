using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSDL_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! It's a wasdl using example");
            Console.ReadLine();

            Calculator.CalculatorSoapClient client = new Calculator.CalculatorSoapClient();            
            Console.WriteLine($"sum of 4 and 5 is: {client.Add(4, 5)}");
            Console.ReadLine();
        }
    }
}