using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CubeOfANUmber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Number you want to find the Cube");
            double input = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Cube of {0} is = {1}", input, FindCube(input));
        }

        public static double FindCube(double Num)
        {
            return Math.Pow(Num, 3);
        }
    }
}
