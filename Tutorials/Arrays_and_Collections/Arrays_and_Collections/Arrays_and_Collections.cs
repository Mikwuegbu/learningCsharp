using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Arrays_and_Collections
{
   class Arrays_and_collections
    {
        static void Main(string[] args)
        {
            //type [ ] identifier = new type [integral size of array];

            int[ ] score = new int [4]; // declaration and instantiating
            score = new int[] { 2, 3, 4, 5 }; // initializing

            char[] Result; //declaration
            Result = new char[3]; //instantiating or dimensioning
            Result = new char[] { '2', '4', '5' }; // initializing the arr Result, skip dimension when your enteries might not match.

            int[] Amount = { 2, 4, 5, 6 }; //Alternative for specifitying size and assigning values same time. useful when data will not change

            int[] Intel = new int[3] { 2, 3, 4 };// Doing everything at once.

            //accessing array
           score[3] = 100;
            Console.WriteLine(score[3]);
            Console.WriteLine(score.Length);

            //Foreach.
            //foreach (type identifier in expression )
            //         statement;

            int[] age = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Console.WriteLine("Series of numbers is");
            foreach (int Val in age)
            {
               Console.WriteLine(" \n{0}", age[0]++);
            }

            //Arrays as method Parameters

          //  Modifiers returnType identifier (type [] arrayIdentifier)

           //void DisplayArrayContents (double [ ] an Array)

            //Two dimensional Array
            //type [ , ] identifier = new type [rowValue, columnValue]

            int[,] scoress = new int[2, 3]  {{ 10, 3, 4 }, { 10, 5, 6}};
            
            //jagged array has specified row buh different column entries

            int [][] jaggedArray = new int [3][];
            jaggedArray[0] = new int []{ 2, 4, 5 };
            jaggedArray[1] = new int []{ 3, 5 };
            jaggedArray[2] = new int [] { 4, 6, 7, 8 };

            //Read up multidimensional Array

            //ArrayList_Members found in the collection class. They are dynamic(Can be changed)

            ArrayList array = new ArrayList(); // this creates an empty array list
            string keylog = Console.ReadLine();
            array.Add(keylog);
                Console.WriteLine("Welcome dear, {0}", array[0]);

            //string Objects Continues;

                string HIGH = "Ikwuegbu Uchechukwu MArk";
                object High;
                High = HIGH.ToUpper(); //Pass the reference string to an Object for manipulations
                Console.WriteLine(High);

            //READ UP: Other Collection classes

        

        }
    }
}