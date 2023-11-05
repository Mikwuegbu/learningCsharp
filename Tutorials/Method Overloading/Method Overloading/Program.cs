using System;


namespace Method_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(6,7,8);
        }

        public static void Add(int FN, int SN)
        {
            Console.WriteLine("The Sum = {0}", FN + SN);
        }

        public static void Add(int FN, int SN, int TN)
        {
            Console.WriteLine("The Sum = {0}",  SN);
        }
    }
}
