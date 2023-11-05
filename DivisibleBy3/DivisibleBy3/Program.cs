using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleBy3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            for (int i = 0; i < 1000; i++)
            {
                n++;
                if(n % 3 == 0 && i <= 1000)
                {
                    Console.WriteLine(n);
                }


            }

        }
    }
}