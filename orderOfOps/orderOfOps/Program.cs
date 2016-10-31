using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderOfOps
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                08/31/2016
                Order Of Operations 
                PEMDAS
                Parenthesis Exponent Multiplication Division Addition Subtraction   */

            //--Find mean of 4 quiz scores

            //--Create quiz scores
            double quiz = 85;
            double quiz2 = 100;
            double quiz3 = 80;
            double quiz4 = 90;

            //--Average
            double mean = (quiz + quiz2 + quiz3 + quiz4) / 4;
            Console.WriteLine("The mean of your quiz scores is: " + mean);

            //--Find perimeter of rectangle
            int length = 8;
            int widthRect = 6;

            int perimeterRect = (2 * length) + (2 * widthRect);
            Console.WriteLine("The perimeter is: " + perimeterRect);





        }
    }
}
