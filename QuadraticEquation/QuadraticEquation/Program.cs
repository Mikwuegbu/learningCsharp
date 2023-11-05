using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {

          
                Console.WriteLine("Program to find the roots of a quadratic equation"
                 + "\n\nAX^2 + BX + C = 0"
                 + "\n-----------------------------------------------------------");
                double a = 0,
                        b = 0,
                        c = 0,
                        x1, x2;


                Console.WriteLine("Input the Value of A");
                a = double.Parse(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("The Value of A cannot be zero ---- \"UNDEFINED\"");
                    while (a == 0)
                    {
                        Console.WriteLine("\n Please Input a valid Value for A");
                        a = double.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nInput the Value of B");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("\nInput the Value of C");
                c = double.Parse(Console.ReadLine());

                x1 = -b + Math.Sqrt(Math.Pow(b, 2)- 4 * a * c);
                x2 = -b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);

                
                Console.WriteLine("The Value of X in the equation is \n\n\t\t x1 = {0} and  x2 = {1}", x1,x2);


        }
    }
}
