using System;


namespace Explicit_Interface_Implementation
{

    interface Istudent
    {
        void printName();
    }

    interface Ipupil
    {
        void printName();
    }

    class Program : Istudent, Ipupil
    {
        void Istudent.printName()
        {
            Console.WriteLine("Istudent printName Method");
        }

        void Ipupil.printName()
        {
            Console.WriteLine("Ipupil printNAme Method");
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            ((Istudent)P).printName(); //We typecast for explicit expression of the interfaces methods;
            ((Ipupil)P).printName();
        }
    }
}
