/*
*   Jordan Hamilton and Luke Kingdon Assignment 2
*   Name of Project: A3LKJHP1
*   Assignment: Part 2 of assignment 3
*   Revision History; 
*       Created 14/11/2022
*
*/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JHLKP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to Conestoga’s PROG1925 Calculator");
                Console.WriteLine("Please Select an Operation");
                Console.WriteLine(" Type 1 for Addition,  \x0A Type 2 for Subtraction,  \x0A Type 3 for Multiplication,  \n Type 4 for Division");


                String userOption = Console.ReadLine();

                if ((System.Int64.Parse(userOption)) <= 0 || (System.Int64.Parse(userOption)) > 4)
                {
                    Console.WriteLine("That is not a Valid option! (Press any Key to Continue)");
                    Console.ReadKey();  
                    System.Environment.Exit(1);
                }

                Console.WriteLine("What is the First Number You Would Like to Enter?");
                int firstNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the Second Number You Would Like to Enter?");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                if (userOption == "1" || userOption == "+")
                {
                    Console.WriteLine(AddOperation(firstNum, secondNum));
                }
                else if (userOption == "2"  || userOption =="-")
                {
                    Console.WriteLine(SubtractOperation(firstNum, secondNum));
                }
                else if (userOption == "3" || userOption =="*")
                {
                    Console.WriteLine(MultiplyOperation(firstNum, secondNum));
                }
                else if ( userOption == "4" || userOption == "/")
                {
                    Console.WriteLine(DivideOperation(firstNum, secondNum));
                }
                else if (userOption == "5")
                {
                    Console.WriteLine("Exiting!");
                    System.Environment.Exit(1);
                }

                Console.ReadKey();
            } 
            catch (FormatException ex){
                Console.WriteLine("That Is Not The Right Format!");
                Console.ReadKey();
            }
            catch (ArgumentNullException ex )
            {
                Console.WriteLine("Please Provide A Valid Character!");
                Console.ReadKey();
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Please Choose a Number between  -9,223,372,036,854,775,807 and +9,223,372,036,854,775,807");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please Provide an input based on the instructions provided!");
                Console.ReadKey();
            }
        }
        public static long AddOperation(System.Int64 inputA, System.Int64 inputB)
        {
            long result;

            result = (inputA + inputB);

            return result;
         
        }

        public static long SubtractOperation(System.Int64 inputA, System.Int64 inputB)
        {
            long result;

            result = (inputA - inputB);

            return result;
        }
        public static long MultiplyOperation(System.Int64 inputA, System.Int64 inputB)
        {
            long result;

            result = (inputA * inputB);

            return result;
        }
        public static long DivideOperation(System.Int64 inputA, System.Int64 inputB)
        {
            long result;

            result = (inputA / inputB);

            return result;
        }

    }
}
