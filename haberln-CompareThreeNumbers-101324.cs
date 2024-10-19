/********************************************************************* 
*    Course:     DEV 110 
*    Instructor: Phil Duncan
*    Term:       Fall 2024
*
*    Programmer: NataschaHaberl
*    Assignment: CompareThreeNumbers
*    
*    Description:   
*    This program compares 3 numbers to see if 2 or all 3 of the numbers are equal
*    
* 
*    Revision    Date               Release Comment 
*    --------     ----------        ------------------------------------------------------ 
*    1.0         10/13/2024         Initial Release 
*    
* 
*/

using System;
using static System.Console;

namespace CompareThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            bool notEqual = true;

            WriteLine("Please enter a number");
            num1 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter another number");
            num2 = Convert.ToInt32(ReadLine());

            WriteLine("Please enter a final number");
            num3 = Convert.ToInt32(ReadLine());

            WriteLine();
            WriteLine($"You entered {num1}, {num2}, and {num3}");
            WriteLine();


            if (num1 == num2)
            {
                notEqual = false;
                if (num3 == num1)
                {
                    WriteLine("All the numbers are equal!");
                }

                else
                {
                    WriteLine("The first two numbers are equal!");
                }
            }


            if (num2 == num3)
            {
                notEqual = false;
                if (num1 == num2)
                {
                    WriteLine("All the numbers are equal!");
                }
                else
                {
                    WriteLine("The last two numbers you entered are equal!");
                }
            }


            if (num1 == num3)
            {
                notEqual = false;
                if (num2 == num3)
                {
                    WriteLine("All the numbers are equal!");
                }
                else
                {
                    WriteLine("The first and third number you entered are equal!");
                }
            }

            if (notEqual == true)
            {
                WriteLine("Sorry, none of the numbers are equal");
            }

            WriteLine();
            WriteLine("Press any key to end program...");
            ReadKey();
        }
    }
}