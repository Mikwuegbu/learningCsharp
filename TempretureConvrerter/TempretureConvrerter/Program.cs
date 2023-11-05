using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string unitOfTemp;
            double F, C, K;

            Console.WriteLine("Temperature Converter");
            Console.WriteLine("\n ------------------------------------");
            Console.WriteLine("Select \n\t -F- = Fahrenheit"
                                    + "\n\t -C- = Celsius "
                                    + "\n\t -K- = Kelvin");

           
            unitOfTemp = Console.ReadLine().ToUpper();

            if (unitOfTemp == "F")
            {
                Console.WriteLine("Input the Value of the Temperature");
                F = Convert.ToDouble(Console.ReadLine());
                C = (F - 32) * 5 / 9;
                K = C + 273.15;
            }
            else
            {
                if (unitOfTemp == "C")
                {
                    Console.WriteLine("Input the Value of the Temperature");
                    C = Convert.ToDouble(Console.ReadLine());
                    F = (C * 9/5) + 32;
                    K = C + 273.15;

                }
                else
                {
                    Console.WriteLine("Input the Value of the Temperature");
                    K = Convert.ToDouble(Console.ReadLine());
                    C = K - 273.15;
                    F = (C * 9 / 5) + 32;
                }
            }

            
        }
    }
}
