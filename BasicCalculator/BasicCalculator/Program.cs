using System;
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

            //--Give user a choice of whether to continue with the program or exit
            if (yesNO == "Yes" || yesNO == "YES" || yesNO == "yes")
            {
                //--User enters first number input
                Console.WriteLine("Enter number: ");
                string inputOne = Console.ReadLine();

                //--Arithmetic Operator selection prompt
                Console.WriteLine("Enter operator: ");
                string operatorNow = Console.ReadLine();

                //--User's second number input
                Console.Write("Enter another number");
                string inputTwo = Console.ReadLine();

                //--Equal
                Console.WriteLine("Press = key: ...");
                string equalNow = Console.ReadLine();

                //--Integer variables
                int input1; int input2;

                //--Convert strings to int types
                input1 = Convert.ToInt32(inputOne);
                input2 = Convert.ToInt32(inputTwo);
                
            } //--Else EXIT the program
            else if (yesNO == "No" || yesNO == "NO" || yesNO == "no")
            {return;}
        }

       
    }
}
