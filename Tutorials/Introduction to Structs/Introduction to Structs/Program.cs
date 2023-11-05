using System;


namespace Introduction_to_Structs
{

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public struct Customer
    {
        private int _id;
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public void printCustomerDetails()
        {
            Console.WriteLine(_id + " " + _name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer C1 = new Customer(101, "Mark");
            C1.printCustomerDetails();

            Customer C2 = new Customer();
            C2.ID = 102;
            C2.Name = "John";
            C2.printCustomerDetails();

           // this object initializing syntax can be used for both structs and classes
            //for less typing and code.
            
            Customer C3 = new Customer
            {
                ID = 103,
                Name = "John"
            };
            C3.printCustomerDetails();

            Student New1 = new Student();
            New1.ID = 123;
            New1.Name = "Mark";

            Student New2 = New1;
            //New2.Name = New1.Name;
            

            Console.WriteLine("New2 = {0}", New2.Name);
        }
    }
}
