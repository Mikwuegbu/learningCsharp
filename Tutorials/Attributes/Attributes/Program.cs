using System;
using System.Collections.Generic;


namespace Attributes
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Print;
            Print = sample.Add(new List<int>() { 1, 2, 3, 4, 5, 6 });
            Console.WriteLine(Print);
        }
    }

    public class sample
    {
        [Obsolete("This is an example of an attribute")]
        public static int Add(List<int> Numbers)
        {
            int Sum = 0;
            foreach (int Number in Numbers)
            {
                Sum = Sum + Number;
            }

            return Sum;
        }
    }
}
