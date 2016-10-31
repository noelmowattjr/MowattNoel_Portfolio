using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDI_Find_Errors_Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //  NAME:  Noel Mowatt
            //  DATE:  09/09/2016
            // Scalable Data Infrastructures
            //  Day 4 Lab
            //  Find and fix the errors

            string myName = "John Doe";
            string myJob = "Cat Wrangler";

            double myRate = 7.50;

            int numberOfCats = 40;
            bool employed = true;

            Console.WriteLine("Hello!  My name is "+myName+".");
            Console.WriteLine("I'm a " + myJob + ".");
            Console.WriteLine("My current assignment has me wrangling " + numberOfCats + " cats.");
            Console.WriteLine("So, let's get to work!");

            while (numberOfCats > 0)
            {

                if (employed = true)
                {

                    Console.WriteLine("I've wrangled another cat.  Only " + numberOfCats + " left!");
                    
                }
                else
                {

                    Console.WriteLine("I've been fired!  Someone else will have to wrangle the rest!");

                };

                numberOfCats--;
               
            }

        }
    }
}





            