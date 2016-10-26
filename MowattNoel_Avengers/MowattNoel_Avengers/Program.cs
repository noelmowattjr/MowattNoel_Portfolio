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

            //--The Villain
            string thanos = "Thanos"; int thanosLifePoints = 100;

            //--The heroes
            string captainAmerica = "Captain America"; int shieldAttack = 11; int throwAttack = 9;
            string ironMan = "Iron Man"; int pulsorAttack = 9; int flingAttack = 8; int blastAttack = 10;
            string thor = "Thor"; int hammerAttack = 12; int punchAttack = 5; int kickAttack = 7;

            //--AvengersArray
            string [] AvengersRoster = new[] { captainAmerica, ironMan, thor };

            //--User's hero
            string hero = Console.ReadLine();

            //--Let's iterate through avengers array
            foreach (string h in AvengersRoster)
            {
                //--Validate that user has in fact chosen a hero from the options given
                if (hero != h)
                {
                    Console.WriteLine("You chose "+hero+" but you must choose from the options presented!\r\nWhich Hero would you like to save earth: Captain Amrica, Iron Man, or Thor?");
                }

                //Console.WriteLine("Hero "+h);
            }
            

                //--test user's choice
                //Console.WriteLine("You chose "+hero );
        }
    }
}
