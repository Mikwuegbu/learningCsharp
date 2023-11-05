using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input the Fahrenheit Value");
            string tempInput = Console.ReadLine();
            double fahrenheit = double.Parse(tempInput);
            const double K = 0.5556;
            double result = (fahrenheit - 32) * 5 / 9;
            Console.WriteLine("{0}F converted to celsius is {1:F3}C", fahrenheit, result);
        }
    }
}
