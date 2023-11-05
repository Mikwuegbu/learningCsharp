using System;
using System.Reflection;

namespace Reflection_LateBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly executingAssembly = Assembly.GetExecutingAssembly();

            Type customerType = executingAssembly.GetType("Reflection_LateBinding");

            object customerInstance = Activator.CreateInstance(customerType);

            MethodInfo getFullNameMethod = customerType.GetMethod("GetFullName");

            string[] parameters = new string[2];
            parameters[0] = " Pragim";
            parameters[1] = "Technologies";

            string FullName = (string)getFullNameMethod.Invoke(customerInstance, parameters);
            Console.WriteLine("Full Name is {0}", FullName);


            //Customer C1 = new Customer();
            //string FullName = C1.GetFullName("Mark", "Stephen");
            //Console.WriteLine("The Full name is {0}", FullName);
        }
    }

    //class Customer
    //{
    //    public string GetFullName(string FirstName, string SecondName)
    //    {
    //        return FirstName + " " + SecondName;
    //    }
    //}
}
