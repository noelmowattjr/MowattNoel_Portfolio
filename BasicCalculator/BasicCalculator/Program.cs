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

            //--Instantiate class properties
            string Addition = OperatorState.GetAddition();
            string Subtraction = OperatorState.GetSubtraction();
            string Multiplication = OperatorState.GetMultiplication();
            string Division = OperatorState.GetDivision();


        }

       
    }
}
