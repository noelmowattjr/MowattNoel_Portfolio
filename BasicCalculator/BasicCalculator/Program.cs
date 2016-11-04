﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                November 2, 2016
                Class: DVP1*/

            /*  This will be a baic functioning calculator that will be strictly console based */

            //--Instantiate class
            ArithmeticOperators OperatorState = new ArithmeticOperators();
            EqualOperator EqualState = new EqualOperator();

            //--Instantiate class properties
            string Addition = OperatorState.GetAddition();
            string Subtraction = OperatorState.GetSubtraction();
            string Multiplication = OperatorState.GetMultiplication();
            string Division = OperatorState.GetDivision();
            string Equal = EqualState.GetEqual();
            
            //--Ask user for name and store it in variable
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();

            //--Welcome user, debrief user, and store user's input
            Console.WriteLine("Hello {0} and welcome to Basic Calculator! With Basic Calculator, you are able to either add, subtract, multiply, and/or divide any two numbers.\r\nReady? Let's begin.", name);
            Console.WriteLine("Type 'Yes' to continue or 'No' to exit and press enter!");
            string yesNO = Console.ReadLine();

            //--Validate user's input for yes or no
            while (yesNO != "Yes" && yesNO != "YES" && yesNO != "yes" && yesNO == "No" && yesNO == "NO" && yesNO == "no")
            {
                Console.WriteLine("Please type Yes or No and press enter.");
                yesNO = Console.ReadLine();
            }

            //----------YES ---or--- NO----------//
            //--To enter or exit Calculator program--//
            if (yesNO == "Yes" || yesNO == "YES" || yesNO == "yes")
            {
                //--Integer variables
                int input1; int input2;

                //--MARK I

                //--User enters first number input
                Console.Write("Press a number and press enter: ");
                string inputOne = Console.ReadLine();

                //--CONVERTED first user's input
                input1 = Convert.ToInt32(inputOne);

                //--Arithmetic Operator selection prompt
                Console.Write("Press an operator and press enter: ");
                string operatorNow = Console.ReadLine();

                //--Addition key pressed--//
                if (operatorNow == Addition)
                {
                    //--New number entered
                    Console.Write("Press another number and press enter: ");
                    string inputTwo = Console.ReadLine();
                    input2 = Convert.ToInt32(inputTwo);

                    //--Equal key pressed
                    //--Get sum of user's two numbers
                    Console.Write("Press equal key and press enter: ");
                    string equalNow = Console.ReadLine();
                    
                    if (equalNow == Equal)
                    {
                        int sum = input1 + input2;
                        Console.WriteLine("You entered {0} and {1} for a sum of {2}", input1, input2, sum);
                    }
                }
                
                //--MARK II 
                

                
                
            } //--Else EXIT the program
            else if (yesNO == "No" || yesNO == "NO" || yesNO == "no")
            {return;}
        }

       
    }
}
