using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateOfBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                Course: DVP1
                App: Date of Birth*/

            /*  INSTRUCTIONS: user inputs DOB and the program outputs how old user is
                in the form of hours and minutes */
                
            //--Prompt user for name
            Console.Write("Hello and what is your name? ");
            string name = Console.ReadLine();
            
            //--Greet user by name and according to time of day
            string greetByName = Greetings(name);

            //--Debrief user
            Console.Write("Today we are going to find out how old you are in hours and minutes!\r\nType Yes to find out or No to exit! Ready? ");
            string toBeOrNotToBe = Console.ReadLine();

            //--VALIDATION: Yes OR No--//
            while (toBeOrNotToBe != "YES" && toBeOrNotToBe != "Yes" && toBeOrNotToBe != "yes" && toBeOrNotToBe != "NO" && toBeOrNotToBe != "No" && toBeOrNotToBe != "no")
            {
                Console.Write("Please enter Yes OR No to continue: ");
                toBeOrNotToBe = Console.ReadLine();
            }

            //--if user enters 'Yes' begin the program
            if (toBeOrNotToBe == "YES" || toBeOrNotToBe == "Yes" || toBeOrNotToBe == "yes")
            {
                //--------------Program Begins Here-----------------//
                Console.WriteLine("Hi and welcome!");


            } 
            
            //--if user enters 'No' then End the program
            else if (toBeOrNotToBe == "NO" || toBeOrNotToBe == "No" || toBeOrNotToBe == "no")
            {
                Console.WriteLine("Maybe next time. Goodbye!");
                return;
            }
            
            

        }
        
        //--Greet user function
        static string Greetings(string me)
        {
            //--Time Object created--//
            DateTime timeOfDay = new DateTime();

            //--Instantiated my time variable to ouput real time
            timeOfDay = DateTime.Now;
            
            //----Filtering the time of day and greeting user accordingly-----//
            if (timeOfDay.Hour >= 0 && timeOfDay.Hour < 12)
            {
                Console.WriteLine("Hi! And good morning {0}. Welcome to our Date of Birth Program!", me);
            }else if (timeOfDay.Hour >= 12 && timeOfDay.Hour < 16)
            {
                Console.WriteLine("Well, good afternoon {0}. Welcome to our Date of Birth Program!", me);
            }else if (timeOfDay.Hour >= 16 && timeOfDay.Hour < 18)
            {
                Console.WriteLine("Hello {0} and good evening! Welcome to our Date of Birth Program!", me);
            }else if (timeOfDay.Hour >= 18)
            {
                Console.WriteLine("Greetings {0}! And good night. Welcome to our Date of Birth Program!", me);
            }return me;
        }
    }
}
