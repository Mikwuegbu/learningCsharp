using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("\n Students Grading System"
                               + "\n ---------------------------------"
                               + "\nInput the Students Grade\n"
                               );
            string input = Console.ReadLine();
            input.ToUpper();

            switch (input)
            {
                case "s":
                    Console.WriteLine("Super");
                    break;
                case "a":
                    Console.WriteLine("Very Good");
                    break;
                case "b":
                    Console.WriteLine("Fair");
                    break;
                case "y":
                    Console.WriteLine("absent");
                    break;
                case "f":
                    Console.WriteLine("Fail");
                    break;
                default:
                    Console.WriteLine("Please Input a Valid Grade");
                    break;
            }
        }
    }
}
