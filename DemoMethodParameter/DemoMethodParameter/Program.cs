using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMethodParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double Total = 0, Product = 0, subtract = 0;
            
            double input1 = Convert.ToDouble(Console.ReadLine());
            double input2 = Convert.ToDouble(Console.ReadLine());
            double input3 = Convert.ToDouble(Console.ReadLine());
            double input4 = Convert.ToDouble(Console.ReadLine());

            Program function = new Program();
           function.Calc(input1, input2, input3, input4, out Total, out subtract, out Product);
           Console.WriteLine("The Total , Subtract and Product is {0} , {1}, {2} respectively", Total, subtract, Product);



        }

        public void Calc(double Num1, double Num2, double Num3, double Num4, out double add, out double sub, out double mul)
        {
            add = Num1 + Num2 + Num3 + Num4;
            sub = Num1 - Num2 - Num3 - Num4;
            mul = Num1 * Num2 * Num3 * Num4;
        }
    }
}
