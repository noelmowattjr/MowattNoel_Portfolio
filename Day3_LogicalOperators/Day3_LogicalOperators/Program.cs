using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            //--LOGICAL OPERATORS--//

            decimal budget = 400.00m;
            decimal iPhone = 500.00m;
            decimal payCheck = 800.00m;

            //--Create conditional to test both conditions
            if (budget > iPhone && payCheck > 700)
            {
                Console.WriteLine("My budget is $"+budget+" so I can afford to buy this new iPhone");
            } else
            {
                Console.WriteLine("My budget is $"+budget+" so I can't afford the iPhone");
            }
            
            //--If at least one side is true then the whole thing is true

           
        }
    }
}
