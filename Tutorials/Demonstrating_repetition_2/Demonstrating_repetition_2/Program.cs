using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demonstrating_repetition_2
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  for(Initialize; conditional expression; update) // any of the expressions can be skipped
           {
            statement to be executed;
        } */
            for(int counter = 0; counter < 11; counter++)
            {
                Console.WriteLine("{0}\t{1}\t{2}",
                    counter,
                    Math.Pow(counter, 2),
                    Math.Pow(counter, 3)); // the declared var can only be used inside the for Loop
            }
            // using the FOREACH loop

            /* foreach (type identifier IN expression)
             {
             Statement
             }
             */

            // Example

            int[] number = {1, 2, 3, 4, 5 };

            foreach(int val in number)
            {
                Console.WriteLine(val);
            }
            
        }
    }
}
