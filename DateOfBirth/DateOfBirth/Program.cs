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
            Console.Write("\r\nToday we are going to find out how old you are in years, hours or minutes!\r\nType Yes to find out or No to exit! (YES/NO)? ");
            string toBeOrNotToBe = Console.ReadLine();

            //--VALIDATION: Yes OR No--//
            while (toBeOrNotToBe != "YES" && toBeOrNotToBe != "Yes" && toBeOrNotToBe != "yes" && toBeOrNotToBe != "NO" && toBeOrNotToBe != "No" && toBeOrNotToBe != "no")
            {
                Console.Write("(YES/NO) to continue: "); toBeOrNotToBe = Console.ReadLine();
            }

            //--if user enters 'Yes' begin the program
            if (toBeOrNotToBe == "YES" || toBeOrNotToBe == "Yes" || toBeOrNotToBe == "yes")
            {
                //--Int holders for user inputs
                int birthY; int birthM; int birthD;
                int yearNow; int monthNow; int dayNow;
                //--------------------------------Program Begins Here---------------------------------------//
                
                //--MARK I

                //--User prompted for current year
                Console.Write("Type the current year: ");
                string currYear = Console.ReadLine();
                while (!(int.TryParse(currYear, out yearNow)))
                {
                    Console.Write("ERROR! Please enter your current year: ");
                    currYear = Console.ReadLine();
                }

                //--User prompted for current month
                Console.Write("Type the current month: ");
                string currMonth = Console.ReadLine();
                while (!(int.TryParse(currMonth, out monthNow)))
                {
                    Console.Write("ERROR! Please enter current month: ");
                    currMonth = Console.ReadLine();
                }

                //--User prompted for current day
                Console.Write("Type today's day: ");
                string currDay = Console.ReadLine();
                while (!(int.TryParse(currDay, out dayNow)))
                {
                    Console.Write("ERROR! Please enter today's day: ");
                    currDay = Console.ReadLine();
                }


                //--MARK II
                //--Prompt & catch year
                Console.Write("Now type your year of birth: ");
                string bYear = Console.ReadLine();

                //--Validate Year
                while (!(int.TryParse(bYear, out birthY)))
                {
                    Console.Write("ERROR! Please enter your birth year: ");
                    bYear = Console.ReadLine();
                }
                
                //--Prompt & catch month
                Console.Write("Month of birth: ");
                string bMonth = Console.ReadLine();

                //--Validate Year
                while (!(int.TryParse(bMonth, out birthM)))
                {
                    Console.Write("ERROR! Please enter your birth month: ");
                    bMonth = Console.ReadLine();
                }

                //--Prompt & catch day
                Console.Write("Day of birth: ");
                string bDay = Console.ReadLine();

                //--Validate Year
                while (!(int.TryParse(bDay, out birthD)))
                {
                    Console.Write("ERROR! Please enter your birth date: ");
                    bDay = Console.ReadLine();
                }

                //--User provides today's date
                DateTime todaysDate = new DateTime(yearNow, monthNow, dayNow);

                //--User provides his/her birthdate
                DateTime myBirthDate = new DateTime(birthY, birthM, birthD);

                //---CALCULATIONS
                var age = todaysDate.Year - myBirthDate.Year; //--Age in years
                var ageInMonths = age * 12; //--age in months
                var ageInWeeks = age * 52;//--age in weeks
                var ageInDays = age * 365;//--age in days
                var ageInHours = age * 8760;//--age in hours
                var ageInMinutes = age * 525600;//--age in minutes

                //--Ask User if they would like their age in years, hours, or minutes
                Console.WriteLine("Would you like to see your age in Years? Hours? Or Minutes?");
                Console.Write("(Years/Hours/Minutes): ");
                string yearsHoursMinutes = Console.ReadLine();

                //--validating that user only enters years, hours, or minutes
                while (yearsHoursMinutes != "years" && yearsHoursMinutes != "hours" && yearsHoursMinutes != "minutes")
                {
                    Console.Write("ERROR! (Years/Hours/Minutes)? ");
                    yearsHoursMinutes = Console.ReadLine();
                }

                //--Displaying user's age according to what he chooses
                if (yearsHoursMinutes.ToLower() == "years" )
                {
                    Console.WriteLine("{0}! You are {1} years old",name, age);
                } else if (yearsHoursMinutes.ToUpper() == "hours" || yearsHoursMinutes.ToLower() == "hours")
                {
                    Console.WriteLine("{0}! You are {1} hours old",name, ageInHours);
                } else if (yearsHoursMinutes.ToUpper() == "minutes" || yearsHoursMinutes.ToLower() == "minutes")
                {
                    Console.WriteLine("{0}! You are {1} minutes old",name, ageInMinutes);
                }

                //--Show user how old he/she is
                //--Console.WriteLine("\r\nBased on the information you gave me, you are {0} years old!\r\nNow to convert that into hours and minutes you are {1} hours old OR  {2}minutes old!",age, ageInHours,ageInMinutes);
                

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

