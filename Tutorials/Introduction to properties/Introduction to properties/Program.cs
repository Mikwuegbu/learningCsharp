using System;

namespace Introduction_to_properties
{
    public class Student 
    {
        private int _ID;
        private string Name;
        private int PassMark = 35;
        //private string _email;
        //private string _city;

        public string email{get;set;}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student identity = new Student();
            Console.WriteLine(identity.email="ccc" );
           
        }
    }
}
