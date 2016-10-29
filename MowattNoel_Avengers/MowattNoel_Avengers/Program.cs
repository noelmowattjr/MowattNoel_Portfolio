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
            /*  Pick 1 of 3 Avengers to fight Thanos and you will only have 5 turns to defeat Thanos
             *  Heroes to choose from below 
             *  -Captain America
             *  -Iron Man
             *  -Thor */

            //--Inform user what's happening
            Console.WriteLine("\r\nThe earth is under attack by Thanos and it is up to you to save it!\r\nYou may choose between 1 of 3 heroes: Captain America, Iron Man, Thor ..then press enter");

            //--The Villain
            string thanos = "Thanos"; double thanosLifePoints = 100; double thanosAttack = 20;

            //--The heroes & Attack
            string captainAmerica = "Captain America";
            string ironMan = "Iron Man";
            string thor = "Thor";
            //--double attack = 20;

            //--AvengersArray
            string [] AvengersRoster = new[] { captainAmerica, ironMan, thor };

            //--User's hero
            string hero = Console.ReadLine();

            //--Validation--//
            //--User must only choose between Cap. America, Iron Man, or Thor - NO Exception
            while (hero != AvengersRoster[0] && hero != AvengersRoster[1] && hero != AvengersRoster[2])
            {
                Console.WriteLine("Please choose one of the listed heroes to fight Thanos and press enter!\r\nCaptain America, Iron Man, or Thor");
                hero = Console.ReadLine();
            }

            //--Confirmation to user of his/her choice of hero
            Console.WriteLine("You have chosen "+hero+" to fight the villainous "+thanos+"! Now let's go stop him and save our world.");


            //----------------//

            //--Prompt user to attack Thanos
            Console.WriteLine("To defeat Thanos, type 'Attack'and press enter");

            //--catch user's response
            string attackString = Console.ReadLine();

            //--Validate that user has in fact entered 'Attack'
            //--This piece of psudo code is from a past pj in SDI (!(double.TryParse(poundsStr, out poundsDouble)))
            while (attackString != "Attack" && attackString != "attack")
            {
                Console.WriteLine("Please type the word 'Attack' and press enter!");
                attackString = Console.ReadLine();
            }
             
                //--Will generate a random number depending on the 2 parameters I will pass
                Random ranNum = new Random();

                //--Turn 1
                if (attackString == "Attack" || attackString == "attack")
                {
                    if (thanosLifePoints == 100)
                    {
                        thanosLifePoints -= ranNum.Next(13, 21);
                        Console.WriteLine(hero + " has attacked Thanos...Thanos now has " + thanosLifePoints + " life points remainding.");
                    }
                    Console.WriteLine(hero + " Attack Thanos again.");
                    attackString = Console.ReadLine();
                }
                //--Turn 2
                if (attackString == "Attack" || attackString == "attack")
                {
                    if (thanosLifePoints != 0)
                    {
                        thanosLifePoints -= ranNum.Next(13, 21);
                        Console.WriteLine(hero + " has attacked Thanos...Thanos now has " + thanosLifePoints + " life points remainding.");
                    }
                    Console.WriteLine(hero + " Attack Thanos again.");
                    attackString = Console.ReadLine();
                }
                //--Turn 3
                if (attackString == "Attack" || attackString == "attack")
                {
                    if (thanosLifePoints != 0)
                    {
                        thanosLifePoints -= ranNum.Next(15, 25);
                        Console.WriteLine(hero + " has attacked Thanos...Thanos now has " + thanosLifePoints + " life points remainding.");
                    }
                    Console.WriteLine(hero + " Attack Thanos again.");
                    attackString = Console.ReadLine();
                }
                //--Turn 4
                if (attackString == "Attack" || attackString == "attack")
                {
                    if (thanosLifePoints != 0)
                    {
                        thanosLifePoints -= ranNum.Next(13, 21);
                        Console.WriteLine(hero + " has attacked Thanos...Thanos now has " + thanosLifePoints + " life points remainding.");
                    }
                    Console.WriteLine(hero + " Attack Thanos again.");
                    attackString = Console.ReadLine();
                }
                //--Turn 5
                if (attackString == "Attack" || attackString == "attack")
                {
                    if (thanosLifePoints != 0)
                    {
                        thanosLifePoints -= ranNum.Next(13, 21);
                        Console.WriteLine("SORRY " + hero + "! You failed to defeat Thanos...he still has " + thanosLifePoints + " life points remainding.");
                    }
                    else
                    {
                        Console.WriteLine("Congratulations " + hero + "! You have defeated " + thanos);
                    }
                }
            //} //--while loop bracket here

        }

       
    }
}
