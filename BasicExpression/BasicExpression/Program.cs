using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                08/31/2016
                Day 2 - Basic Expression
                */

            //--Declare and define a variable
            int a = 2;

            //--change the value of that variable permanently
            a = a + 3;
            Console.WriteLine(a);

            int b = a + 3;
            Console.WriteLine("b = " + b);
            Console.WriteLine("a = " + a);

            //--Expression that frinds our age
            int currentYear = 2016;
            int yearBorn = 1988;

            //--Results
            int age = currentYear - yearBorn;
            Console.WriteLine("You are " + age + " years old");

        }
    }
}
