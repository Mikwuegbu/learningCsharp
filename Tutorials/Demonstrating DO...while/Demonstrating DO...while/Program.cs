using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demonstrating_DO._._.@while
{
    class Program
    {
        static void Main(string[] args)
        {
            //The only posttests statement in c#

            int counter = 10;
            do
            {
                Console.WriteLine(counter + "\t" + Math.Pow(counter, 2));
                counter--;
            }
            while (counter > 0);

            // transferring controls (break, continue, goto, throw, return)
            int total = 0;
            for(int nValue = 0; nValue < 10; nValue++)
            {
                if(nValue == 5)
                {
                    break;
                }
                total += nValue;
                Console.WriteLine(nValue + "\t");
            }
            Console.WriteLine("\nTotal is equal to {0}", total);
            


           
        }
    }
}
