using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the two numbers");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());
            int input3 = int.Parse(Console.ReadLine());


            Program Min = new Program();
            Console.WriteLine("The Smaller NUmber is = {0} ", Min.GetMin(Min.GetMin(input1, input2), input3));
        }

        public int GetMin(int Num1, int Num2)
        {
            return Math.Min(Num1, Num2);
        }
    }
}
