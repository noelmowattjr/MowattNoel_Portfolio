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

            //--Integer variables
            //int input1; 
            int input2;

            //--Ask user for name and store it in variable
            Console.WriteLine("Enter name: "); 
            string name = Console.ReadLine();

            //--Welcome user, debrief user, and store user's input
            Console.WriteLine("Hello {0} and welcome to Basic Calculator! With Basic Calculator, you are able to either add, subtract, multiply, and/or divide any two numbers.\r\nReady? Let's begin.", name);
            Console.WriteLine("Type 'Yes' to continue or 'No' to exit and press enter!");
            string yesNO = Console.ReadLine();

            //--Validate user's input for yes or no
            while (yesNO != "Yes" && yesNO != "YES" && yesNO != "yes" && yesNO != "No" && yesNO != "NO" && yesNO != "no")
            {Console.WriteLine("Please type Yes or No and press enter."); yesNO = Console.ReadLine();}

            //----------YES ---or--- NO----------//
            //--To enter or exit Calculator program--//
            if (yesNO == "Yes" || yesNO == "YES" || yesNO == "yes")
            {
                //--User enters first number input
                Console.Write("Press a number and press enter: ");
                string inputOne = Console.ReadLine();

                //--Validate user number input
                int input_1 = ValidateNumbersInput(inputOne);


                //--Arithmetic Operator selection prompt
                Console.Write("Press an operator and press enter: ");
                string operatorNow = Console.ReadLine();

                //--Validate Operator--//
                while (operatorNow != "+" && operatorNow != "-" && operatorNow != "*" &&   operatorNow != "/")
                {
                    Console.WriteLine("Please enter one of the following Arithmetic Operators and press enter: +, -, *, or /");
                    operatorNow = Console.ReadLine();
                }

                //--Addition key pressed--//
                if (operatorNow == Addition)
                {
                    //--New number entered
                    Console.Write("Press another number and press enter: ");
                    string inputTwo = Console.ReadLine();
                    //--input2 = Convert.ToInt32(inputTwo);

                    //--Validate user number input
                    input2 = ValidateNumbersInput(inputTwo);

                    //--Equal key pressed
                    //--Get sum of user's two numbers
                    Console.Write("Press equal key and press enter: ");
                    string equalNow = Console.ReadLine();
                    
                    if (equalNow == Equal)
                    {
                        int sum = input_1 + input2;
                        Console.WriteLine("You entered {0} and {1} for a sum of {2}", input_1, input2, sum);
                    }
                }
                else if (operatorNow == Subtraction)
                {
                    //--New number entered
                    Console.Write("Press another number and press enter: ");
                    string inputTwo = Console.ReadLine();
                    input2 = ValidateNumbersInput(inputTwo);

                    //--Equal key pressed
                    Console.Write("Press equal key and press enter: ");
                    string equalNow = Console.ReadLine();

                    if (equalNow == Equal)
                    {
                        int difference = input_1 - input2;
                        Console.WriteLine("You entered {0} and {1} for a difference of {2}", input_1, input2, difference);
                    }
                }
                else if (operatorNow == Multiplication)
                {
                    //--New number entered
                    Console.Write("Press another number and press enter: ");
                    string inputTwo = Console.ReadLine();
                    input2 = ValidateNumbersInput(inputTwo);

                    //--Equal key pressed
                    //--Get sum of user's two numbers
                    Console.Write("Press equal key and press enter: ");
                    string equalNow = Console.ReadLine();

                    if (equalNow == Equal)
                    {
                        int product = input_1 * input2;
                        Console.WriteLine("You entered {0} and {1} for a product of {2}", input_1, input2, product);
                    }
                }
                else if (operatorNow == Division)
                {
                    //--New number entered
                    Console.Write("Press another number and press enter: ");
                    string inputTwo = Console.ReadLine();
                    input2 = ValidateNumbersInput(inputTwo);

                    //--Equal key pressed
                    //--Get sum of user's two numbers
                    Console.Write("Press equal key and press enter: ");
                    string equalNow = Console.ReadLine();

                    if (equalNow == Equal)
                    {
                        int quotient = input_1 / input2;
                        Console.WriteLine("You entered {0} and {1} for a quotient of {2}", input_1, input2, quotient);
                    }
                }
            } //--Else EXIT the program
            else if (yesNO == "No" || yesNO == "NO" || yesNO == "no")
            {return;}
        }

        //-----------------------------------------//
        //--VALIDATION NUMBERS Method
        static int ValidateNumbersInput(string i)
        {
            int input;

            //--NUMBER ---- VALIDATION I---//
            while (!(int.TryParse(i, out input)))
            {
                Console.WriteLine("Please only enter numbers!");
                i = Console.ReadLine();
            }
            return input;
        }
    }
}
