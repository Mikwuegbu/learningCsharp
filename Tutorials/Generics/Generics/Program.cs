using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        private static void Main(string[] args)
        {
            bool Equal = Calculator.AreEqual("9", "0");

            if (Equal)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }
        }
    }

    public class Calculator
    {
        public static bool AreEqual<T>(T Value1, T Value2) // generics
        {
            return Value1.Equals(Value2);
        }
    }
}
