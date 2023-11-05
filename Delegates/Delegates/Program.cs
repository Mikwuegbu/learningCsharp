using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public class delegateDemo
    {
       

        public int addition(int x, int y)
        {
            return x + y;
        }

        public int multiply(int x, int y)
        {
            return x * y;
        }

        public int subtract(int x, int y)
        {
            return x - y;
        }
        public int divide(int x, int y)
        {
            return x / y;
        }



    }

    public delegate int processing(int a, int b);

    class Program
    { 
        
        static void Main(string[] args)
        {
            delegateDemo mySample = new delegateDemo();
            processing mySsample = new processing(mySample.subtract);
            Console.WriteLine("{0} , {1}, {2},", mySsample(5, 5), mySsample);
            
            
        }
    }
}
