using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Math
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                08/31/2016
                Math Class  */

            //--Math Operators
            // + Addition - also concatenation when dealing with text
            // - Subtraction
            // * Multiplication
            // / Division

            //--Find area of a triangle
            //--Area of Triangle - W * H / 2

            //--Declare and define the width and height of the triangle
            int width = 8;
            int height = 7;

            //--Find Area
            int areaOfTriangle = (width * height) / 2;
            Console.WriteLine("Your triangle's area is " + areaOfTriangle);
            Console.WriteLine("The area of a Triangle with a width of " + width);
            Console.Write("and a height of " + height + " is " + areaOfTriangle + "\r\n");

            // % Modulo
            //--Using modulo
            decimal twentyDollarsSixCents = 20.06M;
            decimal oneDollar = 1.02m;

            decimal results = twentyDollarsSixCents % oneDollar;
            Console.WriteLine("Modulo: " + results);

            decimal leftOvers = 9007 % 4;
            Console.WriteLine("The leftover is: " + leftOvers);

        }
    }
}
