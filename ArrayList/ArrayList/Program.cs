using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //--Call NamesArray()
            NameArray();

        }

        
        public static void NameArray()
        {
            //--Array of names
            string[] names = new string[] {"Noel Mowatt, Jr.","Marium Shene Abidi","Ms. Stayce","Jesus"};

            //--FOR LOOP - Output array
            for (int seman = 0; seman < names.Length; seman++)
            {
                Console.WriteLine(names[seman]+"is a member of the billionaire club!");
            }

            //--FOREACH LOOP
            foreach (string nam in names)
            {
                Console.WriteLine(nam+" is a brilliant person!");

                //--If we see Noel ask him where is Marium
                if (nam == "Noel Mowatt, Jr.")
                {
                    Console.WriteLine("Hey "+nam+" have you seen "+names[1]+"?");
                } else if (nam == "Marium Shene Abidi")
                {
                    Console.WriteLine("Hi "+nam+", let's go find "+names[3]);
                }
            }


        }
    }
}
