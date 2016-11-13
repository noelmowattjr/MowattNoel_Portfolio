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
            Console.Write("Today we are going to find out how old you are in hours and minutes!\r\nType Yes to find out or No to exit! Ready {0}? ", name);
            string toBeOrNotToBe = Console.ReadLine();

            //--VALIDATION: Yes OR No--//
            while (toBeOrNotToBe != "YES" && toBeOrNotToBe != "Yes" && toBeOrNotToBe != "yes" && toBeOrNotToBe != "NO" && toBeOrNotToBe != "No" && toBeOrNotToBe != "no")
            {
                Console.Write("Please enter Yes OR No to continue: "); toBeOrNotToBe = Console.ReadLine();
            }

            //--if user enters 'Yes' begin the program
            if (toBeOrNotToBe == "YES" || toBeOrNotToBe == "Yes" || toBeOrNotToBe == "yes")
            {
                //--Int holders for user inputs
                int birthY; int birthM; int birthD;

                //--------------Program Begins Here-----------------//
                Console.Write("Hi {0}! Let's get started. Enter your birth year and press enter ", name);
                string bYear = Console.ReadLine();

                //--Validate Year
                while (!(int.TryParse(bYear, out birthY)))
                {
                    Console.Write("Please enter the year you were born and press enter: ");
                    bYear = Console.ReadLine();
                }
                
                Console.Write("Now your birth day: ");
                string bMonth = Console.ReadLine();

                //--Validate Year
                while (!(int.TryParse(bMonth, out birthM)))
                {
                    Console.Write("Please enter the month you were born and press enter: ");
                    bMonth = Console.ReadLine();
                }

                Console.WriteLine("And finally, what is your birth day: ");
                string bDay = Console.ReadLine();

                //--Validate Year
                while (!(int.TryParse(bDay, out birthD)))
                {
                    Console.Write("Please enter the day you were born and press enter: ");
                    bDay = Console.ReadLine();
                }

                //--birthdate
                DateTime myBirthDate = new DateTime(birthY, birthM, birthD);
                Console.WriteLine("Testing birthdate {0}", myBirthDate);
                
                

                //--------------Program Completed-----------------//

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
                //--MORNING
                Console.WriteLine("Good Morning {0}! Welcome to our Date of Birth Program!", me);
            }else if (timeOfDay.Hour >= 12 && timeOfDay.Hour < 16)
            {
                //--AFTERNOON
                Console.WriteLine("Good Afternoon {0}! Welcome to our Date of Birth Program!", me);
            }else if (timeOfDay.Hour >= 16 && timeOfDay.Hour < 18)
            {
                //--EVENING
                Console.WriteLine("Good Evening {0}! Welcome to our Date of Birth Program!", me);
            }else if (timeOfDay.Hour >= 18)
            {
                //--NIGHT
                Console.WriteLine("Good Night {0}! Welcome to our Date of Birth Program!", me);
            }return me;
        }
    }
}
