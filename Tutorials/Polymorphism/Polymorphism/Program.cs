using System;

namespace Encapsulation
{
    public class Employee
    {
        public string firstName = "FN";
        public string lastName = "LN";

        public virtual void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName);
        }
    }

    public class PartTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - part time");
        }
    }

    public class FullTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - full time");
        }
    }

    public class TemporaryTimeEmployee : Employee
    {
        public override void printFullName()
        {
            Console.WriteLine(firstName + " " + lastName + " - temporary Employee");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[4];

            employees[0] = new Employee();
            employees[1] = new PartTimeEmployee();
            employees[2] = new FullTimeEmployee();
            employees[3] = new TemporaryTimeEmployee();

            foreach (Employee e in employees)
            {
                e.printFullName();
            }

            
        }
    }
}
