using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string myName = "Uchechukwu Mark Ikwuegbu";
            char [] mane = myName.ToCharArray();
            Array.Reverse(mane);
            Console.WriteLine(mane);
        }
    }
}
