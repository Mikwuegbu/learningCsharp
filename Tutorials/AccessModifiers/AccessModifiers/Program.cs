using System;

namespace AccessModifiers
{
    public class Customer
    {
        protected int ID;
    }

    public class CorporateCustomer : Customer
    {
        public void PrintID()
        {
            CorporateCustomer CC = new CorporateCustomer();
            CC.ID = 101;
        }
    }

    public class MainClass
    {
        class Program
        {
            static void Main(string[] args)
            {
                Customer c1 = new Customer();
                Console.WriteLine(c1.ID);
            }
        }
    }
}
