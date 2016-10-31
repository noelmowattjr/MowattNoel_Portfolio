using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Runs before PrintMore() func
            Console.WriteLine("Before the function call");

            //--call our PrintMore function
            PrintMore();
            PrintEnjoy();

          
            //--After function call
            Console.WriteLine("After function call");
        }

        //--A func that prints "I hope that you enjoy this program!"
        public static void PrintEnjoy()
        {
            Console.WriteLine("I hope that you enjoy this program!");
 
        }

        //--A function that welcomes Noel to program
        public static void PrintMore()
        {
            //--local variable - string variable with name string
            string userName = "Noel";

            //--Code that will run when I call this function
            Console.WriteLine("Welcome to the program "+userName);
        }
    }
}
