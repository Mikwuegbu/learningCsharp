using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 110,
                Name = "Mark",
                Salary = 5000

            };

            Customer customer2 = new Customer()
            {
                ID = 1100,
                Name = "Stephen",
                Salary = 6500
            };

            Customer customer3 = new Customer()
            {
                ID = 1110,
                Name = "Ikwuegbu",
                Salary = 4500
            };

            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();
            dictionaryCustomers.Add(customer1.ID, customer1);
            dictionaryCustomers.Add(customer2.ID, customer2);
            dictionaryCustomers.Add(customer3.ID, customer3);

            Customer customer110 = dictionaryCustomers[110];

            Console.WriteLine("{0}, {1}, {2}", customer110.ID, customer110.Name, customer110.Salary);


        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
