using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3Validating_Prompts
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Validating User Prompts Using conditionals

            //--Ask user for name
            Console.WriteLine("Hello, please enter name and press enter");

            //--Catch user's response
            var userName = Console.ReadLine();

            //--Test to see if the user left it blank
            if (string.IsNullOrWhiteSpace(userName)) 
            {
                Console.WriteLine("Please enter your name and hit enter");
            } else
            {
                Console.WriteLine("Hello, "+userName+" nice to meet you!oe");
            }

            //--Ask user for number
            Console.WriteLine("Enter a number between 1 - 10");

            //--Catch
            string userNumber = Console.ReadLine();

            //--Convert user's string num to int
            int userInt;

            Console.WriteLine(int.TryParse(userNumber, out userInt));
            Console.WriteLine("This is "+userInt);

            if (!(int.TryParse(userNumber, out userInt)))
            {
                //--run if user enters non valid value
                Console.WriteLine("Please enter a whole number!");

                Console.WriteLine("Please enter a numer between 1 - 10");
                userNumber = Console.ReadLine();

                int.TryParse(userNumber, out userInt);
            }
            Console.WriteLine("The number you entered was: " + userInt);
        }
    }
}
