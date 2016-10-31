using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MowattNoel_TipCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Ask users for their names
            //--User 1
            Console.WriteLine("Please enter your name and press enter"); 
            string user = Console.ReadLine();   

            //--User 2
            Console.WriteLine("Please enter second name and press enter");
            string user2 = Console.ReadLine();

            //--User 3
            Console.WriteLine("Please enter third name and press enter");
            string user3 = Console.ReadLine();
            //----------------------------------//

            //--Menu
            string lobsterStr = "4.25";
            string crabsStr = "3.25";
            string fishStr = "5.05";
            
            //--Tip
            double tip = 20.00 / 100.00;

            //--Welcome users and present menu
            Console.WriteLine("Welcome, "+user+", "+user2+", and "+user3+". Today's menu:\r\n -lobster $"+ lobsterStr + "\r\n -crabs $"+ crabsStr + "\r\n -fish $"+ fishStr);

            //--Ask users to select an item
            Console.WriteLine("Enter a price "+user+" and press enter");

            //--Listen for user's choice
            string userChoice = Console.ReadLine();

            //--CONVERT user's input to double
            double userDouble = double.Parse(userChoice);

            //--Calculate user's total
            double bill = userDouble + (userDouble * tip);

            //--Give user his/her total ncluding tip
            Console.WriteLine("Dear, "+user+" your order was $"+userDouble+" plus a 20% tip, your total is now $"+bill);

            //---USER2
            Console.WriteLine("Enter a price "+user2+" and press enter");
            string user2Choice = Console.ReadLine();        //--Listen to user2 - store user's input
            double user2Double = double.Parse(user2Choice); //--CONVERT user2's input to double
            double bill2 = user2Double + (user2Double * tip); //--Calculate user2's total
            Console.WriteLine("Dear, "+user2+" your order was $" + user2Double + " plus a 20% tip, your total is now $" + bill2);

            //--USER3
            Console.WriteLine("Enter a price " + user3 + " and press enter");
            string user3Choice = Console.ReadLine();        //--Listen to user2 - store user's input
            double user3Double = double.Parse(user3Choice); //--CONVERT user2's input to double
            double bill3 = user3Double + (user3Double * tip); //--Calculate user2's total
            Console.WriteLine("Dear, " + user3 + " your order was $" + user3Double + " plus a 20% tip, your total is now $" + bill3);

            //--Thank customers for eating at our restaurant
            Console.WriteLine("Thank you "+user+", "+user2+", and "+user3+" for choosing to eat with us today!");

            /* STEP 1
             * Prompt 3 user for their names:
             * -Noel
             * -Mom
             * -Dad
             * 
             *  STEP 2
             *  Asked Noel to enter a price according to menu
             *  -Noel chose $4.25
             *  -With 20% tip, Noel's Bill total was $5.1
             *  
             *  STEP 3
             *  Asked Mom to enter a price according to menu
             *  -Mom chose $3.25
             *  -With 20% tip, Mom's Bill total was $3.9
             *  
             *  STEP 4
                Asked Dad to enter a price according to menu
             *  -Dad chose $5.05
             *  -With 20% tip, Dad's Bill total was $6.06
             */
        }
    }
}
