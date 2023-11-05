using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Employee
    {
        public string firstName;
        public string lastName;

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }
    public class partTimeEmployee : Employee
    {

    }

    public class FullTimeEmployee : Employee
    {
        public new void printFullName()  // use the new keyword if the hiding was intentional
        {
            Console.WriteLine(firstName + " " + lastName + " - Contractor");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Mark";
            FTE.lastName = "Stephen";
            FTE.printFullName();
            ((Employee)FTE).printFullName(); // to access the hidden class member;

            Employee Example = new FullTimeEmployee(); // this is possible due to inheritance

            partTimeEmployee PTE = new partTimeEmployee();
            PTE.firstName = "Mark";
            PTE.lastName = "Stephen";
            PTE.printFullName();

            
        }
    }
}
