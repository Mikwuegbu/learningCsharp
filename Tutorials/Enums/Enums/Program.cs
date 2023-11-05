using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public enum Gender
    {
        Unknown,
        Male,
        Female
    }

    public class Customer
    {
        public string Name { get; set; }
        public Gender gender { get; set; }
    }
}