using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestingConditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Where should we go on out vaca day

            //--Test to see if it is warm enough to go to the beach
            //--If it is too cold. Let's go to the mall

            //--if the water temp is warm enough, let's go swimming
            //--if not, let's get a tan
            //--Water temp should be 75 or higher

            //--Setup variable to hold temp
            int temp = 90;

            //--Water temp
            int waterTemp = 60;

            //--Create condition
            if (temp >= 80)
            {
                Console.WriteLine("It is warm enough, let's go to the beach!");
                if (waterTemp >= 75)
                {
                    Console.WriteLine("The water is warm enough, let's go swimming");
                }

            } else
            {
                Console.WriteLine("It is too cold, let's just go to the mall");
            }
       
        }
    }
}
