using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* here lists the classes you can call through out the program as to avoid lenghty typings e.g 
 instead of system.console.writeline(); you can just write console.writeline(); */

namespace TutorialLearning

    // namespace binds the whole program always best to suit the name of thee program to be written
{
    class Program //Every program should have a class it can be named anything
    {
        static void Main(string[] args) /*void shows that no value is to be returned. It can be any datatype. main is the name 
         of the method used*/
        {

            string myName = "Uchechukwu";
            int myAge = 25;
            Console.WriteLine("My name is " + myName + " I am " + myAge + "years old");
            
            decimal Monetary = 878397748.09M; //Used in modern programming for monetary stuffs. the suffix (M) Must be attached. 
            float Scientific = 3.6e-4f; // how to write exponentials (+ = 360000 while - = 0.00036) you must add (f) at the end of floating-point numbers
            
           const int Mark = 78; //declaring a constant variable that cant be altered
                Console.WriteLine(Mark);
                int Security,
                    Data,
                    overflow,
                    hello; // Method of declaring more than one variable at a time.
               
                Security = 89;
                Console.WriteLine(Security++); // unary operators when placed as prefix( increments before display) as surfix (increments after display)
                Console.WriteLine(Security);
                char Hii = '&';
                Console.WriteLine(++Hii); // increments charactrs too
            //compound operations
               /* int answer = 100;
                answer = answer + 5;
                Console.WriteLine(answer); //  below is an alternative*/
                int answer = 100;
                answer += 5;
                Console.WriteLine(answer);
               /* int total = 0;
                int newValue;
                total = total + newValue; // Accumulation*/
            // Casting : converting one type to another>> (dataType) Expresssion
                int value1 = 0,
                    anotherValue = 0;
                    double value2 = 100,
                        anotherDouble = 100;
                    value1 = (int)value2;
                    value2 = (double)anotherValue; // method of casting
                    double price = 1092.89;
                    double Amount = 3456.899;
                    Console.WriteLine("The price is {1:c}", price, Amount ); // formatting output: {placeholder : Sign} they are positioned in the string at the point 
                                                                            //where the value is to be printed
            //Chapter 4: Methods and behaviours
            //n.b you can pop intellisense using ctrl and spacebar

                    double result = Math.Pow(2, 4); // (2, 4) are the parameters
                    Console.WriteLine(result);

        // converting methods

                    double vAlue;
                    string  Var = "45";
                    vAlue = double.Parse(Var);
                    vAlue = Convert.ToDouble(Var);
                    Console.Read();

            // Writing your own class methods i.e writing block of codes as in functions
            // [modifiers(s)] returnType MethodName {parameterList} below is an example

           /*
             public static void DisplayInstructions(double argument1, double argument2)
            
            {
                after typing the executable codes
                return(feet + (double) inches / 12); // this is determined based on the return type( either void, double, int, string etc)
            }
            
            //while calling the method instead of writing the whole code you just call the method alone e.g:
            
           >> DisplayInstructions(16.5, 18.95); // The numbers are the parameters the methods work with
            
            */

            //Making Decisions

         /*If..else and switch statements*/
             
     
    
        }
    }
}
