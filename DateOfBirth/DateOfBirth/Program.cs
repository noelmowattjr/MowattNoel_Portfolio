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

            
            //--Greet user by name
            string greetByName = Greetings(name);
            //--Console.WriteLine(greetByName);
            

        }
        
        //--Greet user function
        static string Greetings(string me)
        {
            //--Time Object created--//
            //--Depending on time of day - user will be greeted by good morning, goodafternoon or goodnight//
            DateTime timeOfDay = new DateTime();

            //--Instantiated my time variable to ouput real time
            timeOfDay = DateTime.Now;
            //--Console.WriteLine("Today is {0}", timeOfDay);
            
            //----Filtering the time of day and greeting user accordingly-----//
            if (timeOfDay.Hour >= 0 && timeOfDay.Hour < 12)
            {
                Console.WriteLine("Hi! And good morning {0}. Welcome to our Date of Birth Program!", me);
            }
            else if (timeOfDay.Hour >= 12 && timeOfDay.Hour < 16)
            {
                Console.WriteLine("Well, good afternoon {0}. Welcome to our Date of Birth Program!", me);
            }
            else if (timeOfDay.Hour >= 16 && timeOfDay.Hour < 18)
            {
                Console.WriteLine("Hello {0} and good evening! Welcome to our Date of Birth Program!", me);
            }
            else if (timeOfDay.Hour >= 18)
            {
                Console.WriteLine("Greetings {0}! And good night. Welcome to our Date of Birth Program!", me);
            }
            return me;
        }
    }
}
