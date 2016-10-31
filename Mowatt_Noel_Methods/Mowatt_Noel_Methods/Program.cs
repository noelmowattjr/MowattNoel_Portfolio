using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mowatt_Noel_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //---------------PROBLEM 1: CIRCUMFERENCE-------------------//
            //--Today we will find the circumference of a circle
            Console.WriteLine("Hello! Today let's find the circumference of your circle.");

            //--Prompt user for diameter
            Console.WriteLine("What is the diameter? Enter a number and press enter");

            //--Capture user's response
            string diameter = Console.ReadLine();

            //--Will house converted user response
            double diameterDouble;

            //--Validate that user has entered a number 
            //--VALIDATE user's response
            while (!(double.TryParse(diameter, out diameterDouble)))
            {
                //--Guide user
                Console.WriteLine("OO-Oh, Please enter a number value for diamter!");

                //--Ask user again
                Console.WriteLine("What is the diameter of your circle?");

                //--Re-capture user's response
                diameter = Console.ReadLine();
            }

            //--Convert user's reply to double
            //double.TryParse(diameter, out diameterDouble);

            //--My pi
            double pi = 3.14;

            //--call func to calculate circumference
            double theCircumference = GetCircumference(pi, diameterDouble);

            //--Tell user the results
            Console.WriteLine("Pi is " + pi + " and you've entered " + diameterDouble + " as your diameter, \r\ntherefore the circumference of your circle is " + theCircumference + "\r\n\r\n");

            //---------------PROBLEM 2: STUNG--------------------//

            //--Inform user what we're doing
            Console.WriteLine("Today we see how many Bee Stings it would take to kill an animal.");
            Console.WriteLine("FYI: it takes 8.666666667 bee stings per pound to kill an animal.\r\n");

            //--Prompt user for animal
            Console.WriteLine("What is the animal");

            //--Capture animal's type
            string animalType = Console.ReadLine();

            //--Ask user to enter a pound number value
            Console.WriteLine("Enter the pounds of the " + animalType + " and press enter");

            //--Catch user's response
            string poundsStr = Console.ReadLine();

            //--Will hold converted string value of user to double
            double poundsDouble;

            //--Validation
            while (!(double.TryParse(poundsStr, out poundsDouble)))
            {
                //--Guide user
                Console.WriteLine("OO-Oh, Please enter a number value for diamter!");

                //--Ask user again
                Console.WriteLine("What is the diameter of your circle?");

                //--Re-capture user's response
                poundsStr = Console.ReadLine();
            }

            //--Call function to calculate user's value
            double beeStings = BeeStings(poundsDouble);

            //--Console results to user
            Console.WriteLine("It takes " + beeStings + " Bee Stings to kill a " + animalType);

            //---------------PROBLEM 3: REVERSE IT --------------------//
           // ReverseThese([1,2,3,4,5,6]);

        }

        //---FUNCTIONS---//

        //--CIRCUMFERENCE Calculator--//
        public static double GetCircumference(double pi, double diameter)
        {
            double circumference = pi * diameter;
            return circumference;
        }
        //----------------------------//

        //-- BEE STINGS TO KILL ANIMAL --//
        public static double BeeStings(double weight)
        {
            double results = weight / 8.666666667;
            return results;
        }
        //-----------------------------//

        /* PROBLEM 1 - CIRCUMFERENCE
         * Prompt 1: What is the diameter? Enter a number and press enter
         * Answer: Left blank and pressed enter.
         * 
         * Prompt 2: OO-Oh, Please enter a number value for diamter!
           What is the diameter of your circle?
           Answer: g

           Prompt 3: OO-Oh, Please enter a number value for diamter!
           What is the diameter of your circle?
           Answer: 5

           Console prints: Pi is 3.14 and you've entered 5 as your diameter,
           therefore the circumference of your circle is 15.7

           PROBLEM 2 - STUNG
           Prompt 1: Today we see how many Bee Stings it would take to kill an animal.
           FYI: it takes 8.666666667 bee stings per pound to kill an animal.

           Prompt 2: What is the animal?
           Answer: Lion

           Prompt 3: Enter the pounds of the Lion and press enter
           Answer: 150

           Console Results: It takes 17.3076923070266 Bee Stings to kill a Lion
         
         */


    }
}
