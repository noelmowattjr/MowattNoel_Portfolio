using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mowatt_Noel_LogicLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Noel Mowatt
                Section 00
                09/09/2016
                Logic and Loops
                */

            //--PROBLEM 1 - TIRE PRESSURE
            double frontPSi = 28.5;
            double backPSi = 36.5;

            if (frontPSi == 28.5 && backPSi == 36.5)
            {
                Console.WriteLine("The tires pass inspection test!\r\n");
            } else
            {
                Console.WriteLine("Get your tires checked out!\r\n");
            }

            //--PROBLEM 2 - Movie Ticket Price
            double movieTicket = 12.00;
            double movieTicDis = 7.00;
            int age = 55;

            int time = 3;

            //--if senior age 55+ or 10 and under OR time is between 3 to 5 then
            if ((age >= 55 || age <= 10) || (time >= 3 || time <= 5))
            {
                Console.WriteLine("You pay $"+movieTicDis+" for your movie ticket");
            }

            //--PROBLEM 3 - For Loop: Add Up The Odds
            int[] nums = new int[6] {10,2,5,10,3,7 };
            int sumOfArray = 0;

            for (int n = 0; n < nums.Length; n++)
            {
                //--if remainder present after division then odd
                if (nums[n] % 2 == 1)
                {
                    Console.Write("Odd number of array: " + nums[n]+"\r\n");
                    sumOfArray += nums[n];
                    Console.WriteLine("Odd sum "+sumOfArray);
                }
            }

            //--PROBLEM 4 - While loop RPG Battle//

            //--Combatants
            string fight1 = "The Rock";
            string fighter2 = "Stone Cold";

            //--Healths of fights
            int fighter1HP = 100;
            int fighter2HP = 79;
            int loseHP = 50;

            //--Random number
            Random randomNum = new Random();

            //--Damage Potential of fighters
            int fighter1DamagePotential = 20;
            int fighter2DamagePotential = 10;

            //--PICKUP HERE
            while (fighter1HP < loseHP )
            {
                fighter1HP--;
                if (fighter1HP <= loseHP)
                {
                    Console.WriteLine(fight1+" Has Lost");
                }
                
            }


        }
    }
}
