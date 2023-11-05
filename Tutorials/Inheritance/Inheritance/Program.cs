using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Employee
    {
       public string firstName;
       public string lastName;
       public string email;

        public void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class FullTimeEmployee : Employee
    {
        public float yearlySalary;
    }

    public class PartTimeEmployee : Employee
    {
        public float hourlyRate;
    }

    public class A : PartTimeEmployee
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
    
            A Derived = new A();
            Derived.email = "DerivedExample";

            FullTimeEmployee FTE = new FullTimeEmployee();
            FTE.firstName = "Mark";
            FTE.lastName = "Stephen";
            FTE.email = "Mstephen130@yahoo.com";
            FTE.yearlySalary = 50000f;
            FTE.printFullName();

            PartTimeEmployee PTE = new PartTimeEmployee();
            PTE.firstName = "Mark";
            PTE.lastName = "Stephen";
            PTE.email = "Mstephen130@yahoo.com";
            PTE.hourlyRate = 50000f;
            PTE.printFullName(); 
        }
    }
}
