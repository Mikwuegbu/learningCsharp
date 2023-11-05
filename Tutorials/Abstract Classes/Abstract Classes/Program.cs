using System;

namespace Abstract_Classes
{
   abstract class Customer
    {
        public abstract void Print();
    }

   class Program : Customer
    {
       public override void Print()
       {
           Console.WriteLine("Print MEthod");
       }
        static void Main(string[] args)
        {
            Customer C = new Program();
            C.Print();
        }
    }
}
