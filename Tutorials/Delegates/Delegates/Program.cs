using System;


namespace Delegates
{
    public delegate void HelloFunctionDelegate(string Message);

    class Program
    {
        static void Main(string[] args)
        {
            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("I am a deleggate");
            // a delegate is a typesafe action pointer;
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    }
}
