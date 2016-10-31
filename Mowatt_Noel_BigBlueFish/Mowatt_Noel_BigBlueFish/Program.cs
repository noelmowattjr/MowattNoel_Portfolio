using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mowatt_Noel_BigBlueFish
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] fishLengths = new double[] {1,2,3,4,5,6,7,8,9,10,11,12};
            string[] colorsFish = new string[] {"red","red","red","red","yellow","yellow","blue","blue","green","green","green","green"};

            //--Present Menu to user
            Console.WriteLine("Welcome to Fish Fest! Today\'s menu includes:");
            Console.WriteLine("Choose\r\n1 for red\r\n2 for red\r\n3 for red\r\n4 for red\r\n5 for yellow\r\n6 for yellow");
            Console.WriteLine("7 for blue\r\n8 for blue\r\n9 for green\r\n10for green\r\n11 for green\r\n12 for green");

            //--catch user's response
            string orderString = Console.ReadLine();
            int orderInt;

            //--Validate that user entered a number and didn't leave blank
            while (!(int.TryParse(orderString, out orderInt)) || (orderInt > 12 || orderInt < 1))
            {
                Console.WriteLine("Oops!");
                Console.WriteLine("Please enter a number value and press enter");
                orderString = Console.ReadLine();
            }

            //--iterates through fishLength array
            for (int i = 0; i < fishLengths.Length; i++)
            {
                if (orderInt >= 1 || orderInt <=4)
                {
                    Console.WriteLine("My ");
                    
                }
            }
            
        }
    }
}
