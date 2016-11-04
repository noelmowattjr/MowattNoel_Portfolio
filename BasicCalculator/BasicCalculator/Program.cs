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
            
            //--Creating my class
           ArithmeticOperators arithmeticOPS = new ArithmeticOperators();

            //--Instantiating my arithmetic operators
            int add = arithmeticOPS.GetPlus();
            int subtract = arithmeticOPS.GetMinus();
            int times = arithmeticOPS.GetMultiply();
            int divide = arithmeticOPS.GetDivide();
            
        
        }

       
    }
}
