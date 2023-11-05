using System;
using System.IO;


namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = null;
            try
            {
                //line of code that might causse an error

                streamReader = new StreamReader(@"C:\Users\MARK STEPHEN PC\Desktop\Hey.txt");
                Console.WriteLine(streamReader.ReadToEnd());
               
                
            }
            catch(FileNotFoundException Ex)
            {
              
               //Console.WriteLine(Ex.StackTrace);
               //Console.WriteLine(Ex.Message);
               Console.WriteLine("Please Check that {0} file exists", Ex.FileName);
            }
            catch(Exception e)
            {

                // THIS EXCEPTION MUST COME LAST
                Console.WriteLine(e.Message);
            }
            finally
            {
                streamReader.Close();
                Console.WriteLine("Finaally");
            }
        }
    }
}
