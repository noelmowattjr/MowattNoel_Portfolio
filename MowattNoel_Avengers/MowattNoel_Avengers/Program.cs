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
            //--GIVENS
            //--Start with 1 zombie
            //--1 Zombie can make 4 Zombies each day
            //--How many Zombies at 8 days?

            //--How many Zombies do we currently have?
            int numOfZombies = 1;

            //--Number of people one Zombie can bite in a day
            int numOfBites = 4;

            //--How many days do we want to know?
            int numOfDays = 8;

            //---Tell User What Is Happening---//
            Console.WriteLine("It's a zombie attack! Let's figure out how many Zombies in 8 Days");

            //--Create a loop to cycle through each of the days
            for (int x = 1; x <= numOfDays; x++)
            {
                //--How many Zombies are create each day?
                int newZombies = numOfZombies * numOfBites;

                //--Bitten people (newZombies) become zombies and join the herd
                numOfZombies += newZombies;

                //--Tell the user how many Zombies there are at day's end
                Console.WriteLine("There are " + numOfZombies + " Zombies at the end of day " + x);
            }

            //--How long will it take to get to a million Zombies

            //--Number of Days
            int days = 1;

            //--Number of Zombies
            int zombies = 1;

            //--Create a While Loop to figure how how many days
            while (zombies <= 10000000)
            {
                //zombies++;

                //--How many people biten pe day
                int bittenPeople = zombies * numOfBites;

                //--End of the day bitten people become Zombies
                zombies += bittenPeople;
                Console.WriteLine("On day #" + days + " there are zombies created " + zombies);

                //--End of the day increment
                days++;
            }
            days--;
            Console.WriteLine("Ending value of days " + days);
        }
    }
}
