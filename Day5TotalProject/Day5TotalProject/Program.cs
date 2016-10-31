using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5TotalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Ask user for width
            Console.WriteLine("What is the Width of your Rectangle?");

            //--Catch user's response
            string widthString = Console.ReadLine();
            
            //--CONVERT user's response to numbers
            double width;
            double height;

            //--VALIDATE user's response
            while (!(double.TryParse(widthString, out width)))
            {
                //--Guide user
                Console.WriteLine("Oops, Please enter a number!");

                //--Ask user again
                Console.WriteLine("What is the width of your rectangle?");

                //--Re-capture user's response
                widthString = Console.ReadLine();
            }

            //--Confirm the user's response
            Console.WriteLine("\r\nGot it! You entered a width of {0}.\r\nWhat is the height of the rectangle?", width);

            //--NOW LET'S GET THE HEIGHT--//
            //--Catch
            string heightString = Console.ReadLine();

            while (!(double.TryParse(heightString, out height)))
            {
                //--Guide user
                Console.WriteLine("Oops, Please enter a number!");

                //--Ask user again
                Console.WriteLine("What is the height of your rectangle?");

                //--Re-capture user's response
                heightString = Console.ReadLine();
            }

            //--GIVE THE USER feedback and let them know we're starting
            Console.WriteLine("We will now calculate the area of a rectangle");

            //--Call and store func
            double theArea = AreaOfRectangle(width, height);

            //--Output to user the results
            Console.WriteLine("Because you entered a width of "+width+" and a height of "+height+", \r\nthe area of your rectangle is: "+theArea);
        }

        //--Area Calc for Rect
        public static double AreaOfRectangle(double w, double h)
        {
            double results = w * h;
            return results;
        }
    }
}
