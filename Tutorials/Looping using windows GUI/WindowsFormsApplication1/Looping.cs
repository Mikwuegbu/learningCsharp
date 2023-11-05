using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping_In_Form
{
    static class Looping
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int counter = 0;
            string result = "";
            while(counter < 10)
            {
                counter++;
                    result += "\t"
                        + counter
                        + "\t"
                        + Math.Pow(counter, 2)
                        + "\n";
            }
            MessageBox.Show(result, "1 through 10 and their " + "squares");
        }
    }
}
