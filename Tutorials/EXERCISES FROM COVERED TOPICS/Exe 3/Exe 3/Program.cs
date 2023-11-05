using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string employerName = "Jessica Daniel";
            Console.WriteLine("The Records of Income for {0}", employerName);
            double weekSales = 28000;
            double totalSales = weekSales * 0.07;
            double fedTax = weekSales * 0.18;
            double retCont = weekSales * 0.10;
            double socialSecurity = weekSales * 0.06;
            Console.WriteLine("\nTotal Week sales: \t {0:C}"
                               + "\nTotal sale amount: \t {1:c}"
                               + "\nFederal Tax :      \t {2:c}"
                               + "\nRetirement Contibutions: {3:c}"
                               + "\nSocial security Amount : {4:c}",
                             weekSales, totalSales, fedTax, retCont, socialSecurity);
        }
    }
}
