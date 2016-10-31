using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Welcome user and ask the question
            Console.WriteLine("Welcome to the Odd or Even Program!\r\nWould you like to see all of the odd numbers or even numbers in our Array?");

            //--Specifically tell the user what the valid choices are
            Console.WriteLine("\r\nPlease enter even or odd");

            //--Catch user's response
            string userInput = Console.ReadLine();
            int userInt;

            //--Validate that user enters numbers
            while (userInput != "even" && userInput != "odd")
            {
                Console.WriteLine("Oops! Please enter even or odd?");
                userInput = Console.ReadLine();
            }
        }
    }
}
