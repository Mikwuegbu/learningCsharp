using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InnerException
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                try
                {


                    Console.WriteLine("Enter the first number");
                    int FN = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int Result = FN / SN;

                    Console.WriteLine("Result = {0}", Result);
                }
                
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\MARK STEPHEN PC\Desktop\Lo.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name);
                        sw.Write(ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("The program encountered a problem, please try agin later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + "is not present", ex);
                    }

                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Current Exception = {0}", exception.GetType().Name);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("InnerException = {0}", exception.InnerException.GetType().Name);
                }

            }
        }
    }
}
