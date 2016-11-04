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
                Instructor: Edward
                Class: Project & Portfolio I*/

            /*  This will be a baic functioning calculator that will be strictly console based */

            //string add;

            //--Created an instance of a class
           ArithmeticOperators arithmeticOPS = new ArithmeticOperators();

            //--Instantiating my plus variable
            char plus = arithmeticOPS.GetPlus();
            
            //--Testing to see if I actually got a plus symbol to print to consol
            Console.WriteLine("This is the add operator: {0}", plus);
        
        }

       
    }
}
