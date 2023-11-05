using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatingAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double j, sum = 0;
            int i = 0;

            do
            {
                j = Convert.ToDouble(Console.ReadLine());
                sum += j;
                i++;
            }
            while (i <= 3);

            double avg = sum / 4;
            Console.WriteLine(avg);
        }
    }
}
