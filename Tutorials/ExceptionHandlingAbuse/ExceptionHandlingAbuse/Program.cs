using System;


namespace ExceptionHandlingAbuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Input the Denominator");
                int Denominator;
                bool IsDenominatorConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);

                if (IsDenominatorConversionSuccessful && Denominator != 0)
                {
                    Console.WriteLine("Input the Denominator");
                    int Numerator;
                    bool isNumeratorConversionSuccesful = Int32.TryParse(Console.ReadLine(), out Numerator);

                    if (Denominator == 0)
                    {

                        Console.WriteLine("Denominator cannot be zero");
                    }
                    else
                    {

                        Console.WriteLine("Input a valid number");
                    }

                    if (isNumeratorConversionSuccesful)
                    {

                        int Result = Numerator / Denominator;

                        Console.WriteLine("Result = {0}", Result);
                    }

                }
                else
                {
                    Console.WriteLine("Please input a valid Denominator of either {0} to {1}", Int32.MaxValue, Int32.MinValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
