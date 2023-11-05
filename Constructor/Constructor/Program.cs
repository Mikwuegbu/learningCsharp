using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Employer
    {
        public static string name;
        public string Surname;

        public Employer()
        {
            name = "No Name";
            Surname = "No Sname";
        }

        public Employer(string Name, string Sname)
        {
            name = Name;
            Surname = Sname;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employer C1 = new Employer("Mark ", "Stephen");
            Console.WriteLine(Employer.name + C1.Surname);

            Employer c2 = new Employer();
            Console.WriteLine(c2.Surname + Employer.name);
        }
    }
}
