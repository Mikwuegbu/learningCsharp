using System;
using System.Collections.Generic;

namespace delegateUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            empList.Add(new Employee() { ID = 101, Name = "Mark", Salary = 5000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "Uche", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Nkechi", Salary = 5000, Experience = 6 });
            empList.Add(new Employee() { ID = 101, Name = "Amaka", Salary = 5000, Experience = 5 });
            empList.Add(new Employee() { ID = 101, Name = "Declare", Salary = 5000, Experience = 4 });
            empList.Add(new Employee() { ID = 101, Name = "Austine", Salary = 5000, Experience = 2 });
            empList.Add(new Employee() { ID = 101, Name = "Esther", Salary = 5000, Experience = 5 });


           // Employee.PromoteEmployee(empList);
        }
    }

    delegate bool IsPromoted(Employee empl);

    public class Employee
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
        public int Experience { set; get; }

        public static void PromoteEmployee(List<Employee> employeeList, IsPromoted IsEligibleToPromote)
        {
            foreach (Employee employee in employeeList)
            {
                if (employee.Experience >= 5)
                {
                    Console.WriteLine(employee.Name + "- promoted");
                }
            }

        }
    }
}
