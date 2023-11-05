using System;


namespace Introduction_to_Interfaces
{
    interface Istudent
    {
        void print1();
        
    }

    interface Ipupil : Istudent
    {
        void print2();
    }

    class Student : Ipupil, Istudent
    {
        public void print1()
        {
            Console.WriteLine("Implementation of the print1 method");
        }

        public void print2()
        {
            Console.WriteLine("Implementation of the Print2 MEthod");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ipupil Name = new Student();
            Name.print1();
            Name.print2();
        }
    }
}
