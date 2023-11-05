using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; // this was added to the Dll through references in the solution explorer

namespace Demonstrating_Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int Sum = 0; // conditional expression must be set before the loop executes
            int number = 1;
            while (number < 11)
            {
                Sum += number;
                number++;
            }
            Console.WriteLine("Sum of the numbers is {0}", Sum);


            int counter = 0;
            string result = "";
            while (counter < 10)
            {
                counter++;
                result += "\t"
                    + counter
                    + "\t"
                    + Math.Pow(counter, 2)
                    + "\n";
            }
            MessageBox.Show(result, "1 through 10 and their " + "squares", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            bool MoreData = true;
            Random numb = new Random(); // Drive mouse here to know hint
            int s = numb.Next(100); // returns positive number < 100

            while (MoreData)
            {
                Console.Write("{0}", s);
                if (MessageBox.Show("Do you want  another number?",
                    "State controlled loop",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question)
                    == DialogResult.No)
                {
                    MoreData = false;
                }
                else
                    s = numb.Next(100);
            }
        }
    }
}
