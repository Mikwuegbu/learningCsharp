using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    class customer
    {
        string _firstname;
        string _lastname;  // the data part of a class also known as the field;

        public customer()
            : this("No lastName provided", "NO firstName provided")
        {

        }

        public customer(string firstname, string lastname)
        {
            //_firstname = firstname;
            //_lastname = lastname;   or 

            this._firstname = firstname;
            this._lastname = lastname;  //constructor of the class customer used to initialize your class fields

        }

        public void printFullName()
        {
            Console.WriteLine("Full name is {0}", _firstname + " " + _lastname);
            //method or behaviour of the class
        }

        ~customer()
        {
            //the destructor (clean up code);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            customer c1 = new customer();
            c1.printFullName();
 
            
        }
    }
}
