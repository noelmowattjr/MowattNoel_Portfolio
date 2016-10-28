﻿using System;
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
            Console.WriteLine("\r\nThe earth is under attack by Thanos and it is up to you to save it!\r\nYou may choose between 1 of 3 heroes: Captain America, Iron Man, Thor ..then press enter");

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

            //--Validation--//
            //--User must only choose between Cap. America, Iron Man, or Thor - NO Exception
            while (hero != AvengersRoster[0] && hero != AvengersRoster[1] && hero != AvengersRoster[2])
            {
                Console.WriteLine("Please choose one of the listed heroes to fight Thanos and press enter!\r\nCaptain America, Iron Man, or Thor");
                hero = Console.ReadLine();
            }

            //--Confirmation to user of his/her choice of hero
            Console.WriteLine("You chose, "+hero+" to fight the villainous "+thanos+"!\r\nNow let's go stop him and save our world.");


            
        }
    }
}
