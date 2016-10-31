using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_AssignmentOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                08/31/2016
                Assignment Operators    */

            /*  ASSIGNMENT OPERATORS    
             
                = assignment operator - assigns a value
                += addition assignment operator
                -= subtraction assignment operator 
                *= multiplication assignment operator
                /= division assignment operator
                
             */

            int toChange = 5; //--value is currently 5
            toChange += 3; //--value is 8
            toChange -= 2; //--value is 6
            toChange *= 2; //--value is 12
            toChange /= 2; //--value is 6

            Console.WriteLine(toChange);

        }
    }
}
