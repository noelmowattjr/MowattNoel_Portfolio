using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MowattNoel_Avengers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Pick 1 of 3 Avengers to fight Thanos  
             *  -Captain America
             *  -Iron Man
             *  -Thor */

            //--Inform user what's happening
            Console.WriteLine("The earth is under attack by Thanos and it is up to you to save it!\r\nYou may choose between 1 of 3 heroes: Captain America, Iron Man, Thor ..then press enter");

            //--User's hero
            string hero = Console.ReadLine();

            //--test user's choice
            Console.WriteLine("You chose "+hero);
        }
    }
}
