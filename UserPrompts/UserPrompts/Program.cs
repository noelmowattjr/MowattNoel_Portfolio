using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPrompts
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                08/31/2016
                User Prompts    */

            //--Console.ReadLine(); - reads the next line in the console and 
            //--returns as text string back to your code

            //--Ask user for name

            //--Ask the question, so user knows what to enter
            Console.WriteLine("Please type in your name and press enter.");

            //--Listen for user - store user's name
            string userName = Console.ReadLine();

            //--Say Hello to user
            Console.WriteLine("Hello, " + userName + " and welcome to the program.");

            //--------------------//
            //--Calculate the perimeter of a rectangle
            //--width*2 + length*2

            //--Explain to user what we are doing
            Console.WriteLine("Let's find out the perimeter of a rectangle!");

            //--Ask user for width
            Console.WriteLine("Please enter a Width and press enter");

            //--Listen for user
            string widthString = Console.ReadLine();

            //--Convert the string to a number data type
            //--Parse command, looks through a text string 
            //--and tries to convert it to the desired datatype
            //--datatype.Parse(stringToConvert)
            double width = double.Parse(widthString);   //--Converts string to double

            //--Ask User for Length
            Console.WriteLine("What is the length?");

            //--Listen
            string lengthString = Console.ReadLine();

            //--Convert
            double length = double.Parse(lengthString);

            //--Results
            double perimeter = (width * 2) + (length * 2);

            //--Output
            Console.WriteLine("The width was "+width+" and the length "+length+" was and thus we have a perimeter of: " + perimeter);
        
        }
    }
}
