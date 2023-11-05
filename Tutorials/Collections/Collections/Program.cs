using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {

            string filename = @"";

            FileStream file = File.Create(filename);
            

            Customer customer1 = new Customer()
            {
                ID = 110,
                Name = "Mark",
                Salary = 3500
            };

            Customer customer2 = new Customer()
            {
                ID = 112,
                Name = "Stephen",
                Salary = 6500
            }; 

            Customer customer3 = new Customer()
            {
                ID = 113,
                Name = "Uchechukwu",
                Salary = 5000
            };

            List<Customer> Customers = new List<Customer>(2);
            Customers.Add(customer1);
            Customers.Add(customer2);
            Customers.Add(customer3);
            Customers.Insert(0, customer3);

            foreach (Customer C in Customers)
            {

                Console.WriteLine("ID = {0}, Name = {1}, salary = {2}", C.ID, C.Name, C.Salary);
            }
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
